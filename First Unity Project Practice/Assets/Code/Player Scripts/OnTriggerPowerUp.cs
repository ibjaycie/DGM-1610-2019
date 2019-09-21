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
		if (other.CompareTag("Player"))
		{
			Pickup();
		}
		
		triggerPowerUpEvent.Invoke();
	
	}

	private void Pickup()
	{
		print("Power Up Picked Up");
	}

}
//9/21/19 Added the pickup function with the help of Brackeys tutoiral, but it's not printing after it's 
//picked up.. . . .
//okay I made it this far, an event has been made where the player triggers it and 
//picks it up. that's all for today. 