using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
	public GameObject[] player;
	public Vector3 spawnPosition = new Vector3(0,1,-7);
	public Bt21PlayerData[] characters;
	public GameObject friendPanel;
	public Text chooseYourFriend;
		

	public void StartGame(int characterChoice) //int assigns a number to the character it will choose
	{
		friendPanel.SetActive(false);
		
		GameObject selectedPlayer = Instantiate(player[characterChoice]); //CAME UP WITH THIS ON MY OWN
		//Woah i'm so smart. But it's spawning BOTH prefabs at the same time. not just one. 
		//var spawnedPlayer = Instantiate(player);
		Bt21PlayerData selectedCharacter = characters[characterChoice];
		//StartCoroutine(Countdown());


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