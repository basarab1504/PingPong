using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            PushLeft();
        else if (Input.GetKey(KeyCode.D))
            PushRight();
    }

    public void PushRight()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public void PushLeft()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        transform.position = new Vector2(-transform.position.x, transform.position.y);
    }
}
