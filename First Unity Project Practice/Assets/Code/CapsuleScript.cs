using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CapsuleScript : MonoBehaviour
{
	public UnityEvent Event;

	private void OnCollisionEnter(Collision other)
	{
		Debug.Log("oops");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
