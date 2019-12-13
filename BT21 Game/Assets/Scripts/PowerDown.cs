using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown : MonoBehaviour 
{
	private WaitForSeconds  wait = new WaitForSeconds(4);
	private void OnTriggerEnter(Collider other)
	{
		StartCoroutine(pickupPowerDown(other));
	}

	IEnumerator pickupPowerDown(Collider player)
	{
		CharacterMovement powerDownSpeed = player.GetComponent<CharacterMovement>();
        
		powerDownSpeed.speed = 3f;
        
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<Collider>().enabled = false;
        
		yield return wait;
        
		powerDownSpeed.speed = 10f;
        
		Destroy(gameObject);
	}
	
}
