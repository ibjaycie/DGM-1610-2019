using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UIHealthImageControllerBloodSupply : MonoBehaviour
{
	private Image healthBar;

	private void Awake()
	{
		healthBar = GetComponent<Image>();
	}

	public void UpdateImage(PlayerHealthData data)
	{
		healthBar.fillAmount = data.totalHealth;
	}
}
