
using System;
using System.Diagnostics;
using UnityEngine;

public class WeaponsHandler : MonoBehaviour
{

	public Debugger weaponObj;

	public void SwitchWeapon(Debugger newWeaponObj)
	{
		weaponObj = newWeaponObj;
	}

	private void Update()
	{
	//	weaponObj.OnWeaponDebug();
	}
}

//I'm Stuck. For some reason "OnWeaponDebug" isn't connecting to my "OnWeaponDebugger" script like
//the "OnDebug" is connecting to the "Debugger". 