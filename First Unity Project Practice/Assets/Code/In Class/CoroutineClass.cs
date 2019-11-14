using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineClass : MonoBehaviour
{
	public bool canRun = true;
	public IntDataObject index; //this way you can effect any float data you've created. 
	public float seconds = 1f;

	private WaitForSeconds wfsObj;

	public void Run()
	{
		wfsObj = new WaitForSeconds(seconds); //created 1 time and used many times. 
		StartCoroutine(OnRun());
	}
	IEnumerator OnRun()
	{
		while (index.value > 0)
		{
			index.value--;
			Debug.Log(index);
			yield return wfsObj;
			
		}
	}
}


