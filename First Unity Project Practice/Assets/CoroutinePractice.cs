using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutinePractice : MonoBehaviour
{
    public ParticleSystem explode;
    public UnityEvent ParticleExplosion;
    
    
    
    IEnumerator OnTriggerEnter(Collider other)
    {
        while (explode)
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("boom");
            explode.Emit(100);
        }
        
    }
}
