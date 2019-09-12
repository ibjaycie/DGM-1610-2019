using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dog : MonoBehaviour
{
	public UnityEvent doStuff; 
	private void OnMouseDown()
	{
		doStuff.Invoke();
	}
}
