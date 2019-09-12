
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class BulletTriggerEvent : MonoBehaviour
{
	public UnityEvent TriggerEvent; 
	//realized I forgot to do the camel casing *face Palm*

	private void OnTriggerEnter(Collider other)
	{
		TriggerEvent.Invoke();
	}
	
	//I want to make it so when the bullet stays on the target
	//The health either stops going down 
	//OR
	//If it stays on the target for like 5 seconds the target gets destroyed.
	//private void OnTriggerStay(Collider other)
	//{
	//	TriggerEvent.Invoke();
	//}
	
	//used a tutorial for the IEnumerator Text on the questions place 
	//on the Unity page
	//IEnumerator ExecuteAfterTime(float time)
	//{
		//yield return new WaitForSeconds(time);
		//Tried to make an if statement still struggling
		//if (Input.onTriggerStay) 
		//{
			
		//}
	}
	

}
