using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BigBoss : MonoBehaviour
{
	public UnityEvent Event;

	private void OnCollisionEnter(Collision other)
	{
		Event.Invoke();
		print("Nomnomnom");
	}

	private void OnCollisionExit(Collision other)
	{
		//I haven't been able to figure out why yet but sometimes when I want to collide with
		//another object, the objects get bumped into 3D space and float the direction it was pushed.
		//Still working on fixing that. 
		Event.Invoke();
		//Not printing the below message. . .hmmmmmmmmmmmm
		print("why won't you die?");
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
