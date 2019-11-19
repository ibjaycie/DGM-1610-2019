using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CountdownCoroutine : MonoBehaviour
{
    public UnityEvent countdown;
    public Text timer;

    public void Start()
    {
        timer.text = "3";
    }
}
//I'm stuck. 
