using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Used Unity Tutorial for This
public class CharacterSelector : MonoBehaviour
{
	//public string Chimmy;
	public GameObject player;
	//public Vector3 playerSpawnPosition = new Vector3(0,1,-7);
	public GameObject[] character;
	public GameObject characterSelectPanel;
	
	public void StartGame(int characterChoice)
	{
		characterSelectPanel.SetActive(false);
		//var newPlayer = Instantiate(GameObject.FindWithTag(Chimmy));
		print("You picked Chimmy");
		//GameObject spawnedPlayer = Instantiate(player) as GameObject;
		//GameObject spawnedPlayer = Instantiate(player, playerSpawnPosition, Quaternion.identity) as GameObject; //Not exactly sure what this means or does. 
		//GameObject selectedCharacter = character[characterChoice]; This is causing errors so goodbye. 
		//I was getting a warning error for these two scripts because it said it wasn't using them and commenting
		//them out fixed it. I used a Unity tutorial for it so oh well. 
	}
	
}
