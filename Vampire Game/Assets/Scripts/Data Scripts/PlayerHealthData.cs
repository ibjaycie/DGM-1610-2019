using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerHealthData : ScriptableObject 
{
    public float totalHealth = 1f;
    public float minHealth = 0f;
    public float maxHealth = 1f;

    public void UpdateHealth(float amount)
    {
        totalHealth += amount;
    }

    public void UpdateHealthRange(float amount)
    {
        if (totalHealth <= maxHealth)
        {
            UpdateHealth(amount);
        }
        else
        {
            totalHealth = maxHealth;
        }

        if (totalHealth >= minHealth)
        {
            UpdateHealth(amount);
        }
        else
        {
            totalHealth = minHealth;
        }
    }
}
