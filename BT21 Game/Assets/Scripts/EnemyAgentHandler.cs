using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAgentHandler : MonoBehaviour
{
	private NavMeshAgent agent;
	private Transform enemyCurrentDestination;
	public Transform[] destinationObject; //If I make this an array i should be able to add more players. But it isn't working. 
	private GameObject startObject;

	private void Start()
	{
		startObject = new GameObject();
		startObject.transform.position = transform.position;
		enemyCurrentDestination = transform;
		agent = GetComponent<NavMeshAgent>();	
	}

	private void OnTriggerEnter(Collider other)
	{
		enemyCurrentDestination = destinationObject;
	}

	private void OnTriggerExit(Collider other)
	{
		enemyCurrentDestination = startObject.transform;
	}

	//private void Update()
	//{
	//	agent.destination = enemyCurrentDestination.position;
	//}
	//currently getting an error that says "Set Destination" can only be called on an
	//object that has an active navmesh. Idk what that means because I have
	//a nav mesh attached to the object. 
}
