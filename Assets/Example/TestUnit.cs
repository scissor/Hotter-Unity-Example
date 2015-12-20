using UnityEngine;

public class TestUnit : MonoBehaviour
{
    public TestUnit()
    {
        Debug.Add( this );
    }

    public virtual void Log()
    {
    }
}
