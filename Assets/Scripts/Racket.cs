using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            Push(Vector2.left);
        else if (Input.GetKey(KeyCode.D))
            Push(Vector2.right);
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
