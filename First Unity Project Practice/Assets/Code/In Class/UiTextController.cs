using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class UiTextController : MonoBehaviour
{
	
	private Text textLabel;

	public void UpdateText(IntDataObject data) //Whenever you update something, name ie update (blah blah blah)
	{
		textLabel.text = data.value.ToString();
	}
	void Awake ()
	{
		
		textLabel = GetComponent<Text>();
		
	}
}
