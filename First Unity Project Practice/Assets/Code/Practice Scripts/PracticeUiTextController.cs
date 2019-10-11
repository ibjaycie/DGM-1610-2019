using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class PracticeUiTextController : MonoBehaviour
{
	private Text textScoreLabel;
	public void UpdateText(IntDataObject data)
	{
		textScoreLabel.text = data.value.ToString();
	}
}
