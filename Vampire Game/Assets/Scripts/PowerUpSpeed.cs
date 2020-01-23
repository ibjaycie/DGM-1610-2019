using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour 
{
    private WaitForSeconds  wait = new WaitForSeconds(4);
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(pickupPowerUp(other));
    }

    IEnumerator pickupPowerUp(Collider player)
    {
        VampireMovement powerUpSpeed = player.GetComponent<VampireMovement>();
        
        powerUpSpeed.speed = 10f;
        
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        
        yield return wait;
        
        powerUpSpeed.speed = 3f;
        
        Destroy(gameObject);
    }
     
}
