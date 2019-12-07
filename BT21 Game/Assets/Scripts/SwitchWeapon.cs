using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchWeapon : MonoBehaviour
{
	public WeaponOptions currentWeapon;
	public UnityEvent onTriggerEvent;
	public GameObject[] weapon;
	public enum WeaponOptions
	{
		ArmyBomb,
		Sword
	}

	//private void Start()
	//{
	//	if (currentWeapon == WeaponOptions.ArmyBomb)
	//	{
	//		Debug.Log("Your current weapon is an Army Bomb!");
	//	}
	//}

	private void OnTriggerEnter(Collider other)
	{
		switch (currentWeapon)
		{
			case WeaponOptions.ArmyBomb:
				onTriggerEvent.Invoke();
				break;
			case WeaponOptions.Sword:
				onTriggerEvent.Invoke();
				break;
		}
	}


}
