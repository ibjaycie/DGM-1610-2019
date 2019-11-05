using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAgentHandler : MonoBehaviour
{
	private NavMeshAgent agent;
	public Vector3 location;
	public GameObject characterPrefab;


	private void Start()
	{
		agent = GetComponent<NavMeshAgent>(); 
	}

	private void Update()
	{
		agent.destination = location;
	}
}
