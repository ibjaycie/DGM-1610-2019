using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticlesOnMouseDown : MonoBehaviour
{

	public ParticleSystem explodeOnMouseDown;

	private void OnMouseDown()
	{
		explodeOnMouseDown.Emit(100); 
	}

	void Start () 
	{
		
	}
	
	
}
