
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
	public float speed = 1f;
	public float jumpSpeed = 20f;
	public float gravity = 9.81f;

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
		//Now to make the double jump. I made the jumpcountmax 2 BUT I want to make other players capable of more or less
		//jumps. For instance, Kookie will have ability to jump max 3 times. But I assume I change that in unity
		//because it is public. 
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

		controller.Move(position * Time.deltaTime);
	}
}
