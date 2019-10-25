using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerWeaponData : ScriptableObject
{
	public Sprite weaponDesign;
	public Color weaponColor = Color.red;
	public int powerLevel = 10;
	public GameObject prefab;
	public string weaponDescription;

}
