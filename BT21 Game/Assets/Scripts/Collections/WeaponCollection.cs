using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

[CreateAssetMenu]
public class WeaponCollection : ScriptableObject
{
    public List<PlayerWeaponData> collectionList;

    public void AddData(PlayerWeaponData obj)
    {
        foreach (var weaponCollection in collectionList)
        {
            Debug.Log(weaponCollection);
        }
    }
    

}
