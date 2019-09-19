
using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MovementInClass : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;
    
    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2; 

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        //position.y = moveSpeed*Input.GetAxis("Vertical"); //Added this on my own. It works woot woot. 
        position.y -= gravity; //-= because it will pull the object down by the speed of gravity rather than
        //push it away. 

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
        
        controller.Move(position*Time.deltaTime);
    }
}
