
using UnityEngine;
[CreateAssetMenu]
public class EnemyHealthBar : ScriptableObject
{

	public float value = 40f;

	public void UpdateValue(float amount)
	{
		value += amount;
	}
}
