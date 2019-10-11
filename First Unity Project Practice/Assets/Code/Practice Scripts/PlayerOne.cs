
using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerOne : MonoBehaviour
{
	public UnityEvent playerAttack;

	private void OnTriggerEnter(Collider other)
	{
		playerAttack.Invoke();
	}
	//This is supposed to do the exact same thing as the onmousedown
	//script I have for the enemies except actives on trigger
	//but it's getting rid of all of them.
}
