using UnityEngine;

public class RacketManager : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private Racket[] rackets;
    private float currentAxis;

    private void Awake()
    {
        rackets = GetComponentsInChildren<Racket>();
    }

    private void Update()
    {
        currentAxis = Input.GetAxis("Horizontal");
        if (currentAxis != 0)
        {
            var vector = new Vector3(currentAxis, 0, 0);
            foreach (var item in rackets)
            {
                item.Push(vector, speed);
            }
        }
    }
}
