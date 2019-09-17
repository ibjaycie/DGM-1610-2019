
using UnityEngine;

public class movement : MonoBehaviour
{
	public Vector3 position;
	public CharacterController controller;
	void Update () 
	{
		//transform.Translate(position*Time.deltaTime);
		controller.Move(position*Time.deltaTime);

	}
}
