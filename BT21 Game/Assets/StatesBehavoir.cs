using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StatesBehavoir : StateMachineBehaviour
{

	public UnityEvent StartEnterEvent, StateUpdateEvent, StateExitEvent; 	 
	
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
     	StartEnterEvent.Invoke();
	}


	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		StateUpdateEvent.Invoke();
	}


	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		StateExitEvent.Invoke();
	}

	
}
