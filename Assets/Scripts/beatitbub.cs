using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beatitbub : MonoBehaviour
{
	float LowerZBound = -2f;
	float UpperZBound = 10000f;
	bool goup = true;
	bool golow = false;
	float velocity = 0.01f;

    void Update()
    {
		if (gameObject.transform.position.z <= UpperZBound && goup)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x+velocity,gameObject.transform.position.y, gameObject.transform.position.z+velocity);        
		}
		else
		{
			golow = true;
		}

		if (gameObject.transform.position.z >= LowerZBound && golow)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y, gameObject.transform.position.z-velocity);        
		}
		else
		{
			goup = true;
		}
    }
}
