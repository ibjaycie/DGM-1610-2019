using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaeMachineAnimation : MonoBehaviour
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
    }
}
