using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
	private Rigidbody rb;
	public Vector3Data forceDirection;
	public float force = 3f;
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		
	}

	private void OnCollisionEnter(Collision other)
	{
		rb.AddForce(forceDirection.value*force);
	}
}
