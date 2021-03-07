using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float minspeed;
    [SerializeField] private float maxspeed;
    Rigidbody2D rgdBody;

    public BallEvent Dropped;

    private void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();
        RandomPush();
    }

    public void RandomPush()
    {
        var random = Random.Range(0f, 1f);
        int x = random > 0.5f ? 1 : -1;
        int y = random < 0.5f ? 1 : -1;

        float speed = Random.Range(minspeed, maxspeed);

        rgdBody.AddForce(new Vector2(x, y) * speed);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Dropped.Invoke(this);
        transform.position = Vector2.zero;
        rgdBody.velocity = Vector2.zero;
        RandomPush();
    }
}
