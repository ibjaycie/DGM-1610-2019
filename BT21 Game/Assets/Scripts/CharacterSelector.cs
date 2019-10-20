using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
	public GameObject player;
	public Vector3 spawnPosition = new Vector3(0,1,-7);
	public Bt21PlayerData[] characters;
	public GameObject friendPanel;

	public void StartGame(int characterChoice) //int assigns a number to the character it will choose
	{
		friendPanel.SetActive(false);
		var spawnedPlayer = Instantiate(player);
		Bt21PlayerData selectedCharacter = characters[characterChoice];
	}

}
