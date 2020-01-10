using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerHealthData : ScriptableObject 
{
    public float totalHealth = 100f;
    public float minHealth = 0f;
    public float maxHealth = 100f;

    public void UpdateHealth(float amount)
    {
        totalHealth -= amount*Time.deltaTime;
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
