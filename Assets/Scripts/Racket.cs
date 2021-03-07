using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField] private float speed;
    private int score;

    public int Score
    {
        get => score;
        set
        {
            score = value;
            ScoreUpdated.Invoke(this);
        }
    }

    public RacketEvent ScoreUpdated;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            PushLeft();
        else if (Input.GetKey(KeyCode.D))
            PushRight();
    }

    private void PushRight()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void PushLeft()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        transform.position = new Vector2(-transform.position.x, transform.position.y);
    }
}
