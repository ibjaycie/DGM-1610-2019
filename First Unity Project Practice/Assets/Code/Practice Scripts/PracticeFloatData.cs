
using UnityEngine;
[CreateAssetMenu]
public class PracticeFloatData : ScriptableObject
{
	public float value = 23f;

	public void UpdateValue(float amount)
	{
		value += amount;
	}

}
