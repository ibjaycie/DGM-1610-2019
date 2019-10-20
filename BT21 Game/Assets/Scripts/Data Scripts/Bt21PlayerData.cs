using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "Character")]
public class Bt21PlayerData : ScriptableObject
{
	public string friendName;
	public Sprite characterImage;
	public int speed = 10;
	public Color outfitColor = Color.red;
}
