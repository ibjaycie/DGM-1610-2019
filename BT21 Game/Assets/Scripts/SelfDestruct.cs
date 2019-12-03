
using System;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
	public float delay = 3f;
	private void Start()
	{
		Destroy(gameObject, delay);
	}

	public void DestroyOnImpact()
	{
		Destroy(gameObject);
	}
}
