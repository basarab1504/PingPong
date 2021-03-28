using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private float minRadius;
    [SerializeField] private float maxRadius;

    private Rigidbody2D rgdBody;

    private void Awake()
    {
        rgdBody = GetComponent<Rigidbody2D>();

        var r = PlayerPrefs.GetFloat("R", 0);
        var g = PlayerPrefs.GetFloat("G", 0);
        var b = PlayerPrefs.GetFloat("B", 0);
        
        GetComponent<SpriteRenderer>().color = new Color(r, g, b);

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
        var radius = Random.Range(minRadius, maxRadius);
        transform.localScale = new Vector3(radius, radius);
    }

    private void SetRandomDirection()
    {
        var x = GenerateRandom();
        var y = GenerateRandom();

        float speed = Random.Range(minSpeed, maxSpeed);

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
