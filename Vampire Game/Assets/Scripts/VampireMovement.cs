using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class VampireMovement : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 1f;
	public float jumpSpeed = 15f;
	public float gravity = 50f;

	private int jumpCount;
	public int jumpCountMax = 2;
	private Vector3 position;
	public Vector3 locationData;
	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
	
	private void Update()
	{
		locationData = transform.position;
		position.x = speed * Input.GetAxis("Horizontal");
		controller.Move(position * Time.deltaTime); 
		
		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
		{
			position.y = jumpSpeed;
			jumpCount++;
		}
		if (controller.isGrounded)
		{
			
			jumpCount = 0;
		}

		
		position.y -= gravity * Time.deltaTime;
	}
}
