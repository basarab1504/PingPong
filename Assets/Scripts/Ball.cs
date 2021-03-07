using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private BallSettings settings;
    private Rigidbody2D rgdBody;

    public BallEvent Dropped;

    private void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().color = settings.Color;
        Reset();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Dropped.Invoke(this);
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
        int x = Random.Range(0f, 1f) > 0.5f ? 1 : -1;
        int y = Random.Range(0f, 1f) > 0.5f ? 1 : -1;

        float speed = Random.Range(settings.MinSpeed, settings.MaxSpeed);

        rgdBody.AddForce(new Vector2(x, y) * speed);
    }
}
