
using UnityEngine;

public class OnTriggerPowerUp : MonoBehaviour
{
	public GameObject pickUpPowerUp;
	public ParticleSystem particleEmit;
	private void OnTriggerEnter(Collider other)
	{
		
		
		if (other.CompareTag("Player"))
		{
			Pickup();
			particleEmit.Emit(100); //YES IT WORKS AND I DID IT WITHOUT BRACKEY WOOT WOOT!!!

		}
	}

	private void Pickup()
	{
		Instantiate(pickUpPowerUp, transform.position, transform.rotation); //used with help of Brackey's, not currently working in unity. 
		//print("Picked Up Power Up");
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