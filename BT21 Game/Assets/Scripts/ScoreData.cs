using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ScoreData : ScriptableObject 
{
	public int value = 100;

	public void updatevalue(int number)
	{
		value += number;
	}
	
}
