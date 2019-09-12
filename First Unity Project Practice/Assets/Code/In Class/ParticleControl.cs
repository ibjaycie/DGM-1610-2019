using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
	public ParticleSystem particles;
	
	void Start () 
	{
		particles.Emit(100);
	}
	
	
}
