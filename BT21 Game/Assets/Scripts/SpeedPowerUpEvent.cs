using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUpEvent : MonoBehaviour
{
	public float powerSpeed = 10f;
	public GameObject[] playerPrefab;
	public CharacterMovement movementOfCharacter;

	private void OnTriggerEnter(Collider other)
	{
		StartCoroutine(SpeedPowerUp());
		//StartCoroutine(SpeedPowerUp(playerPrefab[playerMovement]));
	}

	IEnumerator SpeedPowerUp()
	//IEnumerator SpeedPowerUp(int playerMovement)
	{
		//playerPrefab. = powerSpeed;
		yield return new WaitForSeconds(3f);
		movementOfCharacter.speed = 20f;
		Debug.Log("Times Up for Power Up Speed");
	}
}
