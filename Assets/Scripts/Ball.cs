using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rgdBody;

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
        rgdBody.AddForce(new Vector2(x, y) * speed);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        transform.position = Vector2.zero;
        rgdBody.velocity = Vector2.zero;
        RandomPush();
    }
}
