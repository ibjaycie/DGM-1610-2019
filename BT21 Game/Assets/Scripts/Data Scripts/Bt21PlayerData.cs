using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu (menuName = "Character")]
//[RequireComponent(typeof(NavMeshObstacle))] Trying to make it so I can require the 
//the nav mesh obstacle so i don't hae to apply it to every prefab. 
public class Bt21PlayerData : ScriptableObject
{
	public string friendName;
	public Sprite characterImage;
	public int speed = 10;
	public Color outfitColor = Color.red;
}
