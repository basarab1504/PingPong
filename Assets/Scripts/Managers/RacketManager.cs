using UnityEngine;

public class RacketManager : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private Racket up;
    [SerializeField] private Racket down;
    private float currentAxis;

    private void Update()
    {
        currentAxis = Input.GetAxis("Horizontal");
        if (currentAxis != 0)
        {
            var vector = new Vector3(currentAxis, 0, 0);
            up.Push(vector, speed);
            down.Push(vector, speed);
        }
    }
}
