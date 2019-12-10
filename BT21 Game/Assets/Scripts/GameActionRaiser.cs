﻿using System;
using System.Collections;
using UnityEngine;
public class GameActionRaiser : MonoBehaviour
{
	public float holdTime = 1f;
	public WaitForSeconds waitForSeconds;
	private bool canRun = true;
	public GameAction gameActionObj;
	private void Awake()
	{
		waitForSeconds = new WaitForSeconds(holdTime);
	}

	private IEnumerator OnMouseDown()
	{
		canRun = true;
		while (canRun)
		{
			gameActionObj.Raise(); //raise is another word for call. When we raise actions we invoke events. 
			yield return waitForSeconds;
		}
	}

	private void OnMouseUp()
	{
		canRun = false;
	}
}