using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExplodingSun : MonoBehaviour
{
	public ParticleSystem particlesExplodeSun;

	private void OnMouseEnter()
	{
		particlesExplodeSun.Emit(150);
	}
}
