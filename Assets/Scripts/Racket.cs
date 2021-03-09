using UnityEngine;

public class Racket : MonoBehaviour
{
    public void Push(Vector3 direction, float speed)
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        transform.position = new Vector2(-transform.position.x, transform.position.y);
    }
}
