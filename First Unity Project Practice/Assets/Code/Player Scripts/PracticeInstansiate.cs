using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class PracticeInstansiate : MonoBehaviour
{
	
	public GameObject capsulePlayer;
	public Color playerInitialColor = Color.yellow;
	private GameObject configureGameObject()
	{
		var newPlayer = Instantiate(capsulePlayer);
		newPlayer.tag = "PlayerNumONe";
		newPlayer.GetComponent<Renderer>().material.color = playerInitialColor;
		return newPlayer;
	}

}
