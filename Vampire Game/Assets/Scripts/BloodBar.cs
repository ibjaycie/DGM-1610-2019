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
		//while (true)
		//{
		//	Debug.Log ("OnCoroutine: "+(int)Time.time);
		//	yield return new WaitForSeconds(1f);
		//	slider.value = 
		//}
	}

	public void OnTriggerEnter(Collider target)
	{
		StopCoroutine(BloodBarCountdown());
		StartCoroutine(ReverseBloodBarCountdown());
		
	}

	public void OnTriggerExit(Collider other)
	{
		StopCoroutine(ReverseBloodBarCountdown());
		StartCoroutine(BloodBarCountdown());
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
	}
}
