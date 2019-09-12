using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
	void Update ()
	{
		//if (Input.GetButtonUp()) ; Wanted to see if I could change the color when the cube moves
		//a certain way (Without a tutorial). Will work on this later. 
		//{
		//	GetComponent<Renderer>().material.color = Color.magenta;
		//}
		Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"),0.0f, 0.0f);
		transform.position = transform.position + horizontal * Time.deltaTime;
		Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
		transform.position = transform.position + vertical * Time.deltaTime;
	}
	
}
