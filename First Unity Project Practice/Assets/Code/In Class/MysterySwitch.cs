using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MysterySwitch : MonoBehaviour
{
	public GameObject enemies;

	private void OnMouseEnter()
	{
		print("We have been summoned");
	}
}
