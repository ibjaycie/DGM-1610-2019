using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class OnTriggerEvents : MonoBehaviour
{
	public UnityEvent onTriggerEnter;
	public UnityEvent onTriggerExit;
	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public void OnTriggerEnter(Collider other)
	{
		onTriggerEnter.Invoke();
	}

	public void OnTriggerExit(Collider other)
	{
		onTriggerExit.Invoke();
	}
}
