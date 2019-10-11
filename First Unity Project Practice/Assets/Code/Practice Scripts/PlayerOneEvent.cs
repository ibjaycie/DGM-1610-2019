using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerOneEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		//What i'm trying to do here is when the cube hits the bomb
		//the cube changes color. that's the intended outcome.
		Event.Invoke();
		//if (other.gameObject.activeSelf) not working. 
		//{
		//	GetComponent<Renderer>().material.color = Color.white;
		//}
		//Above isn't doing anything so commenting it out for now. 
		print("change to white please");


	}
	//I initially thought the below script would make the box disappear when i hit enter
	//turns out its been the Mouse Enters the object. haha i'm an idiot i should have read it.
	//But hey it works!
	private void OnMouseEnter()
	{
		Event.Invoke();
		print("I just hit enter");
	}

	private void OnMouseExit()
	{
		Event.Invoke();
		print("That was a close one");
	}

	//Not entirely sure what I did to make this happen, but now my cube player CONSUMES the bomb
	//when it collides with it. . . as well as the cube particles explode not the bombs. I like it though. 
	private void OnCollisionEnter(Collision other)
	{
		Event.Invoke();
		print("I just ran into a bomb");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
