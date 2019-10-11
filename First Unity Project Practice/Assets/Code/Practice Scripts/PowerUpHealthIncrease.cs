using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpHealthIncrease : MonoBehaviour
{
    public UnityEvent increaseHealth;

    private void OnTriggerEnter(Collider other)
    {
        increaseHealth.Invoke();
    }
}
