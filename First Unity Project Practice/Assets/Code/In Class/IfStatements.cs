using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
	public int a = 4;
	public int b = 5;
	public int c = 10;
	public string password = "Mellon";
	public bool lightsOn = false;
	void Start () 
	{
		if (a + b != c) //as long as c is NOT 10, we are good. 
		{
			print(true);
		}
		else
		{
			print(false);
		}

		if (password != "OU812") //as long as the result is NOT OU812, we're good.
		{
			print(true);
		}

		if (!lightsOn) //! is checking if it is false. Lights on is False, so the 
						//Statement itself is true. 
		{
			print(true);
		}
	}
	
	
}
