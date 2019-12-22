using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationPrompt : MonoBehaviour
{
    public GameObject canvas;
    

    private void Start()
    {
        canvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
        StartCoroutine(ConversationBreak());
    }

    IEnumerator ConversationBreak()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Next Response");
    }
    private void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
    
}
