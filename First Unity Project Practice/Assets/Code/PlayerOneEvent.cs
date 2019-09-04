using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerOneEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		//What i'm trying to do here is when the cube hits the bomb
		//the cube changes color. that's the intended outcome.
		Event.Invoke();
		//GetComponent<Renderer>().material.color = Color.white;
		//Above isn't doing anything so commenting it out for now. 
		

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
