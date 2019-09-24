using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFruit : MonoBehaviour
{
	public bool appleIsRipe, orangeIsRipe, peachIsRipe;
	
	void Start () 
	{
		if (appleIsRipe)
		{
			print("Go Pick the Apple");
		}
		else if (orangeIsRipe)
		{
			print("Go Pick the Orange");
		}
		else if (peachIsRipe)
		{
			print("Go Pick the Peach");
		}
		else
		{
			print("Nothing is Ripe. Well shoot darn. ");
		}
		
	}
	
	//correct way to do this, refer to the double jump script! 
}
