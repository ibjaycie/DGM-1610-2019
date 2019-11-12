using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour //used to Delay something or Repeat something. 
{
	//BEST code. 
	private int i = 3; //i is = 0. want it to be something else? define it. 
	private WaitForSeconds wfsObj = new WaitForSeconds(1f);
	public float seconds = 10f;
	IEnumerator Start()
	{
		while (i > 0) //While (i>0) is TRUE, DO the BELOW work. 
		{
			yield return wfsObj; 
			Debug.Log(i);
			i--; //when it runs the second time it becomes a 2, then 0. 
		}
		yield return new WaitForSeconds(1f);
		Debug.Log("Go!");
	}

	//good code
	//Below is OKAY code, but you don't have to write multiple lines. Above is easier. Better.
	//IEnumerator Start() //IEnumerator is a coroutine. 
	//{
	//	yield return new WaitForSeconds(1f); //it will start, wait 1 second then print.
	//	Debug.Log(3);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(2);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log(1);
	//	yield return new WaitForSeconds(1f);
	//	Debug.Log("Go!");
	//}

	//Idea below. Stun an enemy for 3 seconds?
	//Or the player can get a boost
	//CODE ROUTINES CALL EVENTS. 
	//IEnumerator Stun()


	//bad code
	//private void Start()
	//{
	//if you just write StartLater(); then the moment you start the game it will print "ran". 
	//below is bad code. 
	//Invoke("Counter", 1f);
	//Invoke("Counter2", 2f);
	//Invoke("Counter3", 3f);
	//}

	//void Counter()
	//{
	//	Debug.Log(3);
	//}
	//void Counter2()
	//{
	//	Debug.Log(2);
	//}
	//void Counter3()
	//{
	//	Debug.Log(1);
	//}
}
