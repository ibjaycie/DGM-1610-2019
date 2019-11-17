using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementDelayCoroutine : MonoBehaviour
{
	public UnityEvent movementDelay;
	private WaitForSeconds wfsobj = new WaitForSeconds(3f);
	public CharacterMovement script;
	private void Start()
	{
		StartCoroutine(PauseMovement());
	}

	IEnumerator PauseMovement()
	{
		while (script)
		{
			yield return wfsobj;
			Debug.Log("Get Ready");
		}
		yield return wfsobj;
		Debug.Log("You Can Move Now");
	}
}
