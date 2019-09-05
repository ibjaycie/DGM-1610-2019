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


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
