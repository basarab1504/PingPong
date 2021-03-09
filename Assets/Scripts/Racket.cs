using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private InputManager manager;

    private void Start()
    {
        manager.Moving.AddListener(Push);
    }

    public void Push(float direction)
    {
        if (direction > 0)
            Push(Vector2.right);
        else
            Push(Vector2.left);
    }

    private void Push(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        transform.position = new Vector2(-transform.position.x, transform.position.y);
    }
}
