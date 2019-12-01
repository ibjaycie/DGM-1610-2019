using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUpEvent : MonoBehaviour
{
	private float powerSpeed = 10f;
	public GameObject[] playerPrefab;

	private void OnTriggerEnter(Collider other)
	{
		StartCoroutine(SpeedPowerUp());
	}

	IEnumerator SpeedPowerUp()
	{
		//playerPrefab. = powerSpeed;
		yield return new WaitForSeconds(3f);
		Debug.Log("Times Up for Power Up Speed");
	}
}
