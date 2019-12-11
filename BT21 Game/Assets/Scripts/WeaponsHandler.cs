using UnityEngine;

public class WeaponsHandler : MonoBehaviour
{
	public GameObject currentWeapon;
	

	public void UpdateWeapon(GameObject newWeapon)
	{
		currentWeapon = newWeapon;
		
	}

	
}
