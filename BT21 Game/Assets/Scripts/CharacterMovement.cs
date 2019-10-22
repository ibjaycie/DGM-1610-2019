using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public float speed = 1f;
	public float gravity = -3f;

	private Vector3 position;
	public CharacterController controller;

	private void Update()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		controller.Move(position * Time.deltaTime);
	}
}
