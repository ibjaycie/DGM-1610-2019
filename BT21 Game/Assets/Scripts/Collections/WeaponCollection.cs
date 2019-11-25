using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

[CreateAssetMenu]
public class WeaponCollection : ScriptableObject
{
    public List<PlayerWeaponData> weaponList;

    
    public void AddData(PlayerWeaponData obj)
    {
        foreach (var weaponCollection in weaponList)
        {
            Debug.Log(weaponCollection);
        }
        for (var i = 0; i < weaponList.Count; i++)
        {
            if (!weaponList.Contains(obj))
            {
                weaponList.Add(obj);
                Debug.Log("Weapons inside of the chest");
            }
        }
    }
    

}
