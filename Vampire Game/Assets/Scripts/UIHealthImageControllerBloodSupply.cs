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

	private void Start()
	{
		healthBar.fillAmount = maxHealth;
	}

	private void Update()
	{
		//healthBar.fillAmount = Time.deltaTime; //okay this is doing something but idk what right now. 
		//healthBar.fillAmount = maxHealth - 5f* Time.deltaTime;
		//if (Input.anyKey)
		//{
		//	healthBar.fillAmount = maxHealth - 1f;
		//}

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
