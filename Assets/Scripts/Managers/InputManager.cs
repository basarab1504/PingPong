using UnityEngine;

public class InputManager : MonoBehaviour
{
    private float lastCheckedAxis;
    private float currentAxis;
    
    public FloatEvent Moving;

    private void Update()
    {
        currentAxis = Input.GetAxis("Horizontal");
        if (lastCheckedAxis != currentAxis)
        {
            lastCheckedAxis = currentAxis;
            Moving.Invoke(lastCheckedAxis);
        }
    }
}
