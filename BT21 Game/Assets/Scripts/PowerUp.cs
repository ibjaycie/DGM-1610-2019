using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
   private WaitForSeconds wait = new WaitForSeconds(4f);
   private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(pickupPowerUp(other));
    }

    IEnumerator pickupPowerUp(Collider player)
    {
        CharacterMovement powerUpSpeed = player.GetComponent<CharacterMovement>();
        
        powerUpSpeed.speed = 100f;
        
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        
        yield return wait;
        
        powerUpSpeed.speed = 10f;
        
        Destroy(gameObject);
    }
}

//YES I FINALLY FIGURED IT OUT WHY DID THIS TAKE SO LONG. It took me forever (with the hep
//of brackeys for the past month) to figure out hwo to reference another script UGH. Finally. 
