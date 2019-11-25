using UnityEngine;
[CreateAssetMenu]
public class OnWeaponDebugger : ScriptableObject
{
	public void OnWeaponDebug(string words)
	{
		Debug.Log(words);
	}

	public void OnWeaponDebug()
	{
		Debug.Log(name);
	}

}
