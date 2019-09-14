using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExplodingEnemies : MonoBehaviour
{
	public ParticleSystem particlesExplodeEnemies;

	private void OnMouseDown()
	{
		particlesExplodeEnemies.Emit(20);
	}
}
