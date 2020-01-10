using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCoRoutine : MonoBehaviour 
{
	private WaitForSeconds wfsobj = new WaitForSeconds(3f); //My intention here is that his health slowly
	//depletes the longer he goes without drank blood. 
	private void Update()
	{
		StartCoroutine(depleteHealth());
	}

	IEnumerator depleteHealth()
	{
		yield return wfsobj;
		
		Debug.Log("Out of Blood Supply");
	}
}

//I Think I have the basic, but I need to figure out how to apply it. 
//I need to connect it to an Image to show the slow depletion of health, I need to hook 
//It to my health data. And Also apply it to the character. 
//Maybe as well when he attacks a human do I have to have a coroutine that counteracts
//this one to add health? then start over?
//ADD ON TRIGGER ENTER TO SOMETHING TO STOP THIS COROUTINE SO THE HEALTH CAN BE FILLED?