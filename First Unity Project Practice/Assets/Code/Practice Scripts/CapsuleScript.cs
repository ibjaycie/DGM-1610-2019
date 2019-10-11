using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

public class CapsuleScript : MonoBehaviour
{
	public UnityEvent Event;

	private void OnCollisionEnter(Collision other)
	{
		Debug.Log("oops");
	}

	private void OnCollisionExit(Collision other)
	{
		print("Did that do anything?");
		Destroy(gameObject); //It doesn't destroy everything and Idk why. 
		//I tried a bunch of things. Without a tutorial. 
	}

	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
