using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitParticles : MonoBehaviour
{
	public ParticleSystem particles;

	private void OnTriggerEnter(Collider other)
	{
		particles.Emit(50);
	}
}
