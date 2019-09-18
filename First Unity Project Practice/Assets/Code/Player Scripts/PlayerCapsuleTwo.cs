
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
//Will continue working on this later, What I want to do it make it so when you click 
//On the other player, the movement script for that player is called and then you can play as the other
//player without calling the first player. 
public class PlayerCapsuleTwo : MonoBehaviour
{
    public UnityEvent switchPlayer;

    private void OnMouseDown()
    {
        switchPlayer.Invoke();
    }
}
