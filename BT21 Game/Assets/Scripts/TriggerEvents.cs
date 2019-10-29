using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerEvents : MonoBehaviour
{
	public UnityEvent triggerEvent;

	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	//private void OnTriggerEnter(Collider other)
	//{
	//	triggerEvent.Invoke();
	//}
}
	
	