using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatDataPowerUp : ScriptableObject
{
    public float powerUpHealth = .5f;

    public void UpdateValue(float amount)
    {
        powerUpHealth += amount;
    }
}
