using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverseCoroutine : MonoBehaviour 
{
	public GameObject healthImageCanvas;
	public Slider slider;
	private Image healthBar;
	
	public void OnTriggerEnter(Collider target)
	{
		StartCoroutine(ReverseBloodBarCountdown());
	}

	private void OnTriggerExit(Collider other)
	{
		StopCoroutine(ReverseBloodBarCountdown());
	}

	public IEnumerator ReverseBloodBarCountdown()
	{
		Debug.Log("Filling up on blood");
		if (slider != null)
		{
			float timeSlice = (slider.value / 30);
			while (slider.value >= 0)
			{
				slider.value += timeSlice;
				yield return new WaitForSeconds(1);
				if (slider.value <= 0)
					break;
			}
		}

		yield return null;
	}
	
}
