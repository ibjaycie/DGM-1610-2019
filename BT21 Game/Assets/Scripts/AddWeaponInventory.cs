using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class AddWeaponInventory : ScriptableObject
{
	public List<PlayerWeaponData> collectionList;

	public void AddWeapon(PlayerWeaponData obj)
	{
		for (var i = 0; i < collectionList.Count; i++)
		{
			if (!collectionList.Contains(obj))
			{
				collectionList.Add(obj);
				Debug.Log("You picked up a club");
			}
		}
	}

}
