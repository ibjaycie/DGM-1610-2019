using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class AddWeaponInventory : ScriptableObject
{
	public List<PlayerWeaponData> weaponList;
	public int weaponMax = 2;

	public void AddWeapon(PlayerWeaponData obj)
	{
		for (var i = 0; i < weaponList.Count; i++)
		{
			if (!weaponList.Contains(obj))
			{
				weaponList.Add(obj);
			}
		}
	}

}
