﻿using System;
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
	private GameObject startObj;


	private void Start()
	{
		location = transform;
		startObj = new GameObject();
		startObj.transform.position = transform.position;
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


//actually it's just going to my players zero position. 
//i don't have any errors but it just going to the zero position of the player. 
//the play triggers the movement but the enemy doesn't follow. 