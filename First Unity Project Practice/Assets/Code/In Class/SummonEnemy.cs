using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SummonEnemy : MonoBehaviour
{
	public UnityEvent enemyAppear;

	private void OnMouseExit()
	{
		enemyAppear.Invoke();
	}

	private void Start()
	{
		//I want the cube to be invisible when the game starts
	}
}
