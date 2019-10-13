using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Used Unity Tutorial for This
public class CharacterSelector : MonoBehaviour
{
	public GameObject player;
	public Vector3 playerSpawnPosition = new Vector3(0,1,-7);
	public GameArtClass[] characters;

	public GameObject characterSelectPanel;
	
	public void StartGame(int characterChoice)
	{
		characterSelectPanel.SetActive(false);
		
		GameObject spawnedPlayer = Instantiate(player, playerSpawnPosition, Quaternion.identity) as GameObject; //Not exactly sure what this means or does. 
		GameArtClass selectedCharacter = characters[characterChoice];
	}
	
}
