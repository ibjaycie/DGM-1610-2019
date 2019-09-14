using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SummonEnemy : MonoBehaviour
{
	public UnityEvent enemyAppear;

	private void OnMouseEnter()
	{
		enemyAppear.Invoke();
	}

	private void Start()
	{
		//I want the cube to be invisible when the game starts
		//Update: figured it out. Don't need to put it in start just turn off the cube in unity. 
	}
}
