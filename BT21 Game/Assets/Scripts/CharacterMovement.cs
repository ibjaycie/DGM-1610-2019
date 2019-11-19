
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

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
		
		if (Input.GetButtonDown("Jump")) 
		{
			position.y = jumpSpeed;
			jumpCount++;
		}
		
		position.y -= gravity * Time.deltaTime; 
		controller.Move(position * Time.deltaTime);
		
	}

	
}
