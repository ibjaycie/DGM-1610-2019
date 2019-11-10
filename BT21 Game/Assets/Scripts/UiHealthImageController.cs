using System;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class UiHealthImageController : MonoBehaviour
{
	private Image healthBar;

	private void Awake()
	{
		healthBar = GetComponent<Image>();
	}

	public void UpdateImage(HealthData data)
	{
		healthBar.fillAmount = data.totalHealth;
	}
}
