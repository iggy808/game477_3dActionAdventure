using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceRange : MonoBehaviour
{
	public bool dancing;

	private void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag("Player"))
		{
			dancing = true;
			UnityEngine.AI.NavMeshAgent agent = GetComponentInParent<UnityEngine.AI.NavMeshAgent>();
			agent.enabled = false;
		}
	}
}
