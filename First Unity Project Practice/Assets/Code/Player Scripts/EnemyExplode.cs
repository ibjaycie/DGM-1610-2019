using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EnemyExplode : MonoBehaviour
{
	public UnityEvent enemyDestroy;

	private void OnMouseDown()
	{
		enemyDestroy.Invoke();
	}
}
