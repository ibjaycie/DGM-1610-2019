using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Variables : MonoBehaviour
{
	public float floatValue = 5f;
	public int intValue;
	public string stringValue = "Chim";
	public int firePower;
	//Added in class after commit
	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
		print("Just passing Through");
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
