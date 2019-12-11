using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
	
	public UnityEvent instantiateCountdown;
	public GameObject[] player;
	public Vector3 spawnPosition = new Vector3(0,1,-7);
	public Bt21PlayerData[] characters;
	public GameObject friendPanel;
	public Text chooseYourFriend;
	public GameObject selectedPlayer;
	public int countdown = 3;
	public Text countdownText;
	
		

	public void StartGame(int characterChoice) 
	{
		friendPanel.SetActive(false);
		selectedPlayer = Instantiate(player[characterChoice]); 
		instantiateCountdown.Invoke();
		StartCoroutine(PrintText());
		Time.timeScale = 1;
		Bt21PlayerData selectedCharacter = characters[characterChoice];

	}
	private void Update()
	{
        
		if (countdown >= 1)
		{
			countdownText.text = (" " + countdown); 
		}
		else
		{
			countdownText.text = ("GO!");
		}

		if (countdown <= -1)
		{
			countdownText.text = (" ");
        
		}
		
	}
	IEnumerator PrintText()
	{
		while (countdown > -1)
		{
			yield return new WaitForSeconds (1);
			countdown--;
		}

		while (countdown == 1)
		{
			yield return new WaitForSeconds (1);
			countdownText.text = ("test");
		}
	}
	

	

	

}

