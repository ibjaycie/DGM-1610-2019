using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CountdownCoroutine : MonoBehaviour
{
    
    public int countdown = 3;
    public Text countdownText;
    
    
    private void Update()
    {
        
        if (countdown >= 1)
        {
            countdownText.text = ("" + countdown); 
        }
        else
        {
            countdownText.text = ("GO!");
        }

        if (countdown <= -1)
        {
            countdownText.text = (" ");
        
        }
    }
    
    private void Start()
    {
        StartCoroutine(PrintText());
        Time.timeScale = 1;
    }

    IEnumerator PrintText()
    {
        while (countdown > -1)
        {
            yield return new WaitForSeconds (1);
            countdown--;
        }

        while (countdown == 1)
        {
            yield return new WaitForSeconds (1);
            countdownText.text = ("test");
        }
    }
       
           
    
}
