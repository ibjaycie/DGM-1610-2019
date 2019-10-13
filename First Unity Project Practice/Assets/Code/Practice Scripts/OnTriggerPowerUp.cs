
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerPowerUp : MonoBehaviour
{
	public float multiplier = 1.4f;
	public GameObject pickUpPowerUp;
	public ParticleSystem particleEmit;
	private void OnTriggerEnter(Collider other)
	{
		
		
		if (other.CompareTag("Player"))
		{
			Pickup(other);
			particleEmit.Emit(100); //YES IT WORKS AND I DID IT WITHOUT BRACKEY WOOT WOOT!!!

		}
	}

	private void Pickup(Collider player)
	{
		Instantiate(pickUpPowerUp, transform.position, transform.rotation);
		player.transform.localScale *= multiplier; //Added this with help of Brackey's tutorial
		//Use this script as a reference to add the double jump power up and maybe even a time period for it!> 
		Destroy(gameObject);
	}

}
//IT WORKS! I had too much information and the if statment is acutally referring to the Power up and
//Need to be applied to the power up not the player because is is asking if the "player" is true pick
//up the object. Figured that out on my own, good job Jaycie. 
//9/21/19 Added the pickup function with the help of Brackeys tutoiral, but it's not printing after it's 
//picked up.. . . .
//okay I made it this far, an event has been made where the player triggers it and 
//picks it up. that's all for today. 