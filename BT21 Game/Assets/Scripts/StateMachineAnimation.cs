using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineAnimation : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) ||Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("IsWalking", true);
            Debug.Log("You're Walking");
        }
        else
        {
            anim.SetBool("IsWalking", false);
            Debug.Log("You're Idle");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("IsJumping", true);
            Debug.Log("You're Walking");
        }
    }
}
