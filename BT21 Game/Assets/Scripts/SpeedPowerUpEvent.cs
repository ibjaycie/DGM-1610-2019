using UnityEngine;

public class SpeedPowerUpEvent : MonoBehaviour
{
	public float powerSpeed = 10f;
	public GameObject[] playerPrefab;
	public CharacterMovement movementOfCharacter;

	private void OnTriggerEnter(Collider other)
	{
		PowerUpSpeed(other);
		
	}

	void PowerUpSpeed(Collider playerSpeed)
	{
		playerSpeed.GetComponent<CharacterMovement>();

	}
}
