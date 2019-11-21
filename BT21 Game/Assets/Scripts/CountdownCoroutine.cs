using System;
using System.Collections;
using System.Collections.Generic;
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
            countdownText.text = ("" + countdown); //Showing the Score on the Canvas
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
        StartCoroutine(printText());
        Time.timeScale = 1;
    }
    IEnumerator printText()
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
        //yield return new WaitForSeconds(1f);
        //countdownText.text = "You Can Move Now!";
        //countdown--;
           
    
}
