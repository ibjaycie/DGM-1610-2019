using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AgentHandler : MonoBehaviour
{	
	private NavMeshAgent agent;
	private Transform currentDestination;
	public Transform destinationObj;
	private GameObject startObj;
	
	private void Start()
	{
		startObj = new GameObject();
		startObj.transform.position = transform.position;
		currentDestination = transform; //follows itself. 
		agent = GetComponent<NavMeshAgent>();
	}

	private void OnTriggerEnter(Collider other)
	{
		currentDestination = destinationObj; //this will change the destination to you. 
		//so until you cross paths it will pursue you. 
	}

	private void OnTriggerExit(Collider other)
	{

		currentDestination = startObj.transform;
	}

	private void Update()
	{
		agent.destination = currentDestination.position; //our AI will chase our player around. 
	}
}
