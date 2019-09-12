using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyEverything : MonoBehaviour
{
	public UnityEvent Event;
	private void OnTriggerEnter(Collider other)
	{
		Collider.Destroy(gameObject); //well this worked!! Did that on my own. 
		//(Collider.DestroyImmediate(gameObject));
		{
			print("Item destroyed");
			Destroy(gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
