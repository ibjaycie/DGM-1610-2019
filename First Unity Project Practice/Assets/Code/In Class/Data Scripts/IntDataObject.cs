using UnityEngine;

[CreateAssetMenu]
public class IntDataObject : ScriptableObject
{
    public int value = 1; //A scriptable object is simply "an object that contains data"

    public void updatevalue(int number)
    {
        value += number;
    }
}
