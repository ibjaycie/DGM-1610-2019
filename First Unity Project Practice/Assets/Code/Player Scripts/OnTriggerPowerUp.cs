using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnTriggerPowerUp : MonoBehaviour
{
	public UnityEvent triggerPowerUpEvent;

	private void OnTriggerEnter(Collider other)
	{
		triggerPowerUpEvent.Invoke();
	}
}
//okay I made it this far, an event has been made where the player  triggers it and 
//pick it up. that's all for today. 