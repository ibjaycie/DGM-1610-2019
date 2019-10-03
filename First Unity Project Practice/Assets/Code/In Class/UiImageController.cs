using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class UiImageController : MonoBehaviour
{
	private Image img;
	
	void Awake ()
	{
		img = GetComponent<Image>();
	}

	public void UpdateImage(FloatData data) //not naming it health because you can use this for any type of bar to update data
	{
		img.fillAmount = data.value;
	}
}
