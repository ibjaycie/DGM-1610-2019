using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterInfo : ScriptableObject
{
	public string characterName;
	public string characterDescription;
	public int health;
	public int speed;
	public Sprite weapon;
	public Sprite artwork;
	public Color playerColor = Color.yellow;
	
	
	
	private float IncreaseSpeed(float multiplier)
	{
		return speed * multiplier;
	}


}
