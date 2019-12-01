using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyShoot :  MonoBehaviour
{
	public float shootSpeed;
	public ParticleSystem bullet;
	public float maxBullets = 1f;
	public Vector3 direction;

	private void OnTriggerEnter(Collider other)
	{
		bullet.Emit(1);
		
	}
}
