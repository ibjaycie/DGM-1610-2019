using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleSystemDestroy : MonoBehaviour
{
	public UnityEvent Event;

	//I want this once the particles hit an object they destroy the object.
	private void OnCollisionEnter(Collision other)
	{
		Event.Invoke();
		//if (OnCollisionEnter(Collision other))
		//{
		//	Event.Invoke(other);
		//}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
