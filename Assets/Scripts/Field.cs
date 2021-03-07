using UnityEngine;

public class Field : MonoBehaviour
{
    private void Start()
    {
        Camera camera = Camera.main;
        float height = 2f * camera.orthographicSize;
        float width = height * camera.aspect;

        var colliders = GetComponents<BoxCollider2D>();

        colliders[0].size = new Vector2(width, height);

        colliders[1].size = new Vector2(1, height);
        colliders[1].offset = new Vector2(-width * 0.5f, 0);

        colliders[2].size = new Vector2(1, height);
        colliders[2].offset = new Vector2(width * 0.5f, 0);
    }
}
