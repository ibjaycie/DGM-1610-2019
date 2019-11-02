
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
