using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UIHealthImageControllerBloodSupply : MonoBehaviour
{
	public float totalHealth = 100f;
	public float minHealth = 0f;
	public float maxHealth = 100f;
	private Image healthBar;

	private void Awake()
	{
		healthBar = GetComponent<Image>();
	}

	
	public void UpdateImage(PlayerHealthData data)
	{
		healthBar.fillAmount = data.totalHealth;
	}
	public void UpdateHealth(float amount)
	{
		totalHealth -= amount*Time.deltaTime;
	}
}
