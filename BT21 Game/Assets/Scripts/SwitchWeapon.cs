using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchWeapon : MonoBehaviour
{
	//public WeaponOptions currentWeapon;
	//public UnityEvent onTriggerEvent;
	//public GameObject[] weapon;
	public int selectedWeapon = 0;
//	public enum WeaponOptions
//	{
//		ArmyBomb,
//		Sword
//	}

	private void Start()
	{
		SelectedWeapon();
	}

	private void Update()
	{
		int previousSelectedWeapon = selectedWeapon;
		
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if (selectedWeapon >= transform.childCount - 1)
				selectedWeapon = 0;
			else
				selectedWeapon++;
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			if (selectedWeapon <= 0)
				selectedWeapon = transform.childCount - 1;
			else
				selectedWeapon--;
		}

		if (previousSelectedWeapon != selectedWeapon)
		{
			SelectedWeapon();
		}
	}

	void SelectedWeapon()
	{
		int i = 0;
		foreach (Transform weapon in transform)
		{
			if (i == selectedWeapon)
			{
				weapon.gameObject.SetActive(true);
			}
			else
			{
				weapon.gameObject.SetActive(false);
			}
			i++;
		}
	}

//	private void OnTriggerEnter(Collider other)
//	{
//		switch (currentWeapon)
//		{
//			case WeaponOptions.ArmyBomb:
//				onTriggerEvent.Invoke();
//				break;
//			case WeaponOptions.Sword:
//				onTriggerEvent.Invoke();
//				break;
//		}
//	}


}
