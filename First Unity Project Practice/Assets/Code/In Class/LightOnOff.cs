using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightOnOff : MonoBehaviour
{
	public UnityEvent lightSwitch;

	private void OnMouseDown()
	{
		lightSwitch.Invoke();
	}
}
