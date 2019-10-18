using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onButtonSelect : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab);
    }
}
