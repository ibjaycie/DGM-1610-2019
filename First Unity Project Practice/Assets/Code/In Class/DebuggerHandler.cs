using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggerHandler : MonoBehaviour
{
    public Debugger debuggerObj;

    public void SwitchDebugger(Debugger newDebuggerObj)
    {
        debuggerObj = newDebuggerObj;
    }
    private void Update()
    {
        debuggerObj.OnDebug();
    }
    
}
