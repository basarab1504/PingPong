using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private BallSettings settings;
    private Rigidbody2D rgdBody;

    private void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();

        GetComponent<SpriteRenderer>().color = settings.Color;

        SetRandomSize();
        SetRandomDirection();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Reset();
    }

    private void Reset()
    {
        transform.position = Vector2.zero;
        rgdBody.velocity = Vector2.zero;

        SetRandomSize();
        SetRandomDirection();
    }

    private void SetRandomSize()
    {
        var radius = Random.Range(settings.MinRadius, settings.MaxRadius);
        transform.localScale = new Vector3(radius, radius);
    }

    private void SetRandomDirection()
    {
        var x = GenerateRandom();
        var y = GenerateRandom();

        float speed = Random.Range(settings.MinSpeed, settings.MaxSpeed);

        rgdBody.AddForce(new Vector2(x, y) * speed);
    }

    private float GenerateRandom()
    {
        float number;
        do
        {
            number = Random.Range(-1f, 1f);
        }
        while (number == 0);
        return number;
    }
}
