using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerInteract : MonoBehaviour
{
	[SerializeField]
	ScenarioController ScenarioController;    

	public bool InteractKeyPressed;
	
	void Start()
	{
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
			InteractKeyPressed = true;
			Debug.Log("Player triggered interaction.");
            float interactRange = 2f;

            // If there is anything with a collider within the interaction range...
            // Add it to a list of colliders 
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                // If the collider has the NPCInteractable script...
                if(collider.TryGetComponent(out NPCInteractable npc))
                {
					Debug.Log("Nearby npc has npcinteractable component");
                    // Disable player movement
                    gameObject.GetComponent<PlayerMovement>().enabled = false;
                    
					Debug.Log("npc.dialoguecamera.enabled == false ?  : " + (npc.DialogueCamera.enabled == false));
                    // If the npc isn't speaking
                    if(npc.DialogueCamera.enabled == false)
                    {
                        // Call the interact function
                        npc.Interact();
                        // move the player to the NPC's player position.
                        gameObject.transform.position = npc.transform.Find("PlayerPos").position;
                    }
                    
                }


                // If the collided object has an ItemInteractable script
                if (collider.TryGetComponent(out ItemInteractable item) )
                {
                    Debug.Log(item);
                    // if the object has been interacted with 
                    if (item.interacted == false)
                    {
                        item.Interact();
                    }
                }
            }
        }
		else
		{
			InteractKeyPressed = false;
		}
    }
}
