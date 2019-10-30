using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class OnWeaponDebug : ScriptableObject
{
	public void StartWeaponDebug(String words)
	{
		Debug.Log(words);
	}

}
