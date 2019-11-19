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
        countdownText.text = (" " + countdown);
    }

    private void on()
    {
        StartCoroutine(PauseMovement());
    }
    IEnumerator PauseMovement()
    {
        while (countdown > -1)
        {
            
            if (countdown <= 0)
            {
                yield return new WaitForSeconds(1f);
                countdownText.text = "You Can Move Now!";
                countdown--;
            }
            else
            {
                yield return new WaitForSeconds(1f);
                countdown--;
            }
            
        }
        Debug.Log("YOU CAN MOVE NOW");
    }
}
