using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.J))
		{
			GetComponent<Renderer>().material.color = Color.magenta;
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			GetComponent<Renderer>().material.color = Color.black;
		}

		if (Input.GetKeyDown(KeyCode.T))
		{
			GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
}
