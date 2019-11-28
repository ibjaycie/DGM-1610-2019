
using System.Collections;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
	public float speed = 1f;
	public float jumpSpeed = 15f;
	public float gravity = 50f;

	private int jumpCount;
	public int jumpCountMax = 2;
	private Vector3 position;
	public CharacterController controller;
	public bool grounded;
	public bool canDoubleJump;
	
	

	private void Start()
	{
		
		controller = GetComponent<CharacterController>();
		speed = 0f;
		StartCoroutine(PauseMovement());
		
	}

	IEnumerator PauseMovement()
	{
		
		yield return new WaitForSeconds(3f);
		speed = 10f;
		Debug.Log("You can move now");
		
	}

	private void Update()
	{

		position.x = speed * Input.GetAxis("Horizontal");
		controller.Move(position * Time.deltaTime);

		if (controller.isGrounded)
		{
			position.y = jumpSpeed;
			jumpCount = 0;
		}

		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
		{
			position.y = jumpSpeed;
			jumpCount++;
		}
		position.y -= gravity * Time.deltaTime;
	}
}
