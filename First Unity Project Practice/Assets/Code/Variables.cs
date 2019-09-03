using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
	public float floatValue = 5f;
	public int intValue;
	public string stringValue = "Chim";
	public int firePower;

	private void OnTriggerEnter(Collider other)
	{
		print("Just passing through");
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
