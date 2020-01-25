using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BloodBar : MonoBehaviour
{
	public GameObject healthImageCanvas;
	public Slider slider;
	private Image healthBar;

	private void Start()
	{
		healthImageCanvas.SetActive(true);
		slider.value = 1f;
		StartCoroutine(BloodBarCountdown());
		
	}

	IEnumerator BloodBarCountdown()
	{
		//below help from unity
		if (slider != null)
		{
			float timeSlice = (slider.value / 60);
			while (slider.value >= 0)
			{
				slider.value -= timeSlice;
				yield return new WaitForSeconds(1);
				if (slider.value <= 0)
					break;
			}
		}
		yield return null;
	}
}
