
using System;
using UnityEngine;
using UnityEngine.Events;


public class PlayerTriggerOffSwitch : MonoBehaviour
{
    public UnityEvent playerTriggerOffSwitch;

    private void OnTriggerEnter(Collider other)
    {
        playerTriggerOffSwitch.Invoke();
    }
}
//how do I make multiple things happen if this trigger is called? I'm asking myself
//so I can figure it out later. 