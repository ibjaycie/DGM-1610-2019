using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerHandler : ScriptableObject
{
	public PlayerData playerDataObj; //This is the script that allows you to swap players

	public void SwitchPlayer(PlayerData data)
	{
		playerDataObj = data;
	}
	public void OnRun()
	{
		playerDataObj.Run();
	}

}
