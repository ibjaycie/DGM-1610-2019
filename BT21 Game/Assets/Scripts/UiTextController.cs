using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UiTextController : MonoBehaviour
{
	public Text scoreUpdate;

	public void UpdateText(ScoreData data)
	{
		scoreUpdate.text = data.value.ToString();
		
	}

	private void Awake()
	{
		scoreUpdate = GetComponent<Text>();
	}
}
