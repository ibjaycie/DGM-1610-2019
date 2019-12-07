
using System;
using System.Diagnostics;
using UnityEngine;

public class WeaponsHandler : MonoBehaviour
{
	public GameObject currentWeapon;
	

	public void UpdateWeapon(GameObject newWeapon)
	{
		currentWeapon = newWeapon;
		
	}

	//private void Update()
	//{
	//	weaponObj.onWeaponDebug();
	//}
}

//I'm Stuck. For some reason "OnWeaponDebug" isn't connecting to my "OnWeaponDebugger" script like
//the "OnDebug" is connecting to the "Debugger". 