
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
	public float speed = 1f;
	public float jumpSpeed = 20f;
	public float gravity = 9.8f;

	private int jumpCount;
	public int jumpCountMax = 2;
	private Vector3 position;
	public CharacterController controller;


	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	private void Update()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		controller.Move(position * Time.deltaTime);
		
		if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
		{
			position.y = jumpSpeed;
			jumpCount++;
		}

		if (controller.isGrounded)
		{
			position.y = 0f;
			jumpCount = 0; 
		}

		position.y -= gravity * Time.deltaTime; //YES THIS WORKED. okay but now it can't jump. 
		//okay so it jumps if gravity is at 3 in unity, but then it falls back down really really slow. working on fixing that.
		//need to ponder for a bit. 
		controller.Move(position * Time.deltaTime);
	}
}
