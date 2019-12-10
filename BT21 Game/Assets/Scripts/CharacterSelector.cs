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
	//public Text selectPrompt;
		

	public void StartGame(int characterChoice) //int assigns a number to the character it will choose
	{
		friendPanel.SetActive(false);
		//selectPrompt.SetActive(false);
		selectedPlayer = Instantiate(player[characterChoice]); //CAME UP WITH THIS ON MY OWN
		instantiateCountdown.Invoke();
		StartCoroutine(PrintText());
		Time.timeScale = 1;
		//Woah i'm so smart. But it's spawning BOTH prefabs at the same time. not just one. 
		//var spawnedPlayer = Instantiate(player);
		Bt21PlayerData selectedCharacter = characters[characterChoice];
		//StartCoroutine(Countdown());

	}
	private void Update()
	{
        
		if (countdown >= 1)
		{
			countdownText.text = (" " + countdown); //Showing the Score on the Canvas
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
	

	

	

	//IEnumerator Countdown()
	//{
	//	yield return new WaitForSeconds(3f);
	//	Debug.Log("Start Game");
		
	//}
}

//I UNDERSTAND WHAT'S WRONG! In the brackeys tutorial, he only has ONE player prefab
//and the ONLY difference in the two characters he has is the ABILITIES. 
//I have two completely different character (That will need prefabs I guess and I will
// have 7 characters). 

//IT FLIPPIN WORKED AND I DID LINE 15 OF SCRIPT ON MY OWN JUST FROM THINKING OUT LOUD
//HOLY CRAP I CAN'T BELEIVE IT FLIPPIN WORKED! I COULD CRY!

//November 23, 2019 I FINALLY FINGURED IT OUT I NEEDED TO PUT MY DARN COROUTINE INSIDE OF THIS SCRIPT IN ORDER FOR IT
//TO INSTATIATE PROPERLY AND DELAY PROPERLY I'M SO FREAKING HAPPY WOOT WOOT. 