using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAgentHandler : MonoBehaviour
{
	private NavMeshAgent agent;
	private Transform currentDestination;
	public Transform playerDestination;
	private GameObject startObj;


	private void Start()
	{
		startObj = new GameObject();
		startObj.transform.position = transform.position;
		currentDestination = transform;
		agent = GetComponent<NavMeshAgent>(); 
	}

	private void OnTriggerEnter(Collider other)
	{
		currentDestination = playerDestination;
	}

	private void OnTriggerExit(Collider other)
	{
		playerDestination = startObj.transform;
	}

	private void Update()
	{
		agent.destination = currentDestination.position;
	}
}


//actually it's just going to my players zero position. 
//i don't have any errors but it just going to the zero position of the player. 
//the play triggers the movement but the enemy doesn't follow. 