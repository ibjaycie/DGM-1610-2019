using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class PracticeUiImageController : MonoBehaviour
{
	private Image imageBar;

	public void UpdateImage(FloatData data)
	{
		imageBar.fillAmount = data.value;
	}

}
