using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAgentHandler : MonoBehaviour
{
	private NavMeshAgent agent;
	private Transform location;
	public Transform playerDestination;


	private void Start()
	{
		location = transform;
		agent = GetComponent<NavMeshAgent>(); 
	}

	private void OnTriggerEnter(Collider other)
	{
		location = playerDestination;
	}

	private void Update()
	{
		agent.destination = location.position;
	}
}


//IT WORKED! I needed to make the enemy boxcollider bigger as well as make the Location = transform
//in order for it to follow correctly. 