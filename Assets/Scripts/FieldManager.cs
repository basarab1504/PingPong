using UnityEngine;

public class FieldManager : MonoBehaviour
{
    [SerializeField] BoxCollider2D playField;
    [SerializeField] BoxCollider2D wallLeft;
    [SerializeField] BoxCollider2D wallRight;
    [SerializeField] BoxCollider2D zoneUp;
    [SerializeField] BoxCollider2D zoneDown;

    private void Start()
    {
        GetCameraSize(out float height, out float width);
        AdjustBorders(height, width);
    }

    private void GetCameraSize(out float height, out float width)
    {
        Camera camera = Camera.main;

        height = 2f * camera.orthographicSize;
        width = height * camera.aspect;
    }

    private void AdjustBorders(float height, float width)
    {
        playField.size = new Vector2(width, height);

        Vector2 wallSize = new Vector2(1, height);
        Vector2 wallOffset = new Vector2(width * 0.5f, 0);

        Adjust(wallRight, wallSize, wallOffset);
        Adjust(wallLeft, wallSize, -wallOffset);

        Vector2 zoneSize = new Vector2(width, 0.5f);
        Vector2 zoneOffset = new Vector2(0, height * 0.5f);

        Adjust(zoneUp, zoneSize, zoneOffset);
        Adjust(zoneDown, zoneSize, -zoneOffset);
    }

    private void Adjust(BoxCollider2D collider2D, Vector2 size, Vector2 offset)
    {
        collider2D.size = size;
        collider2D.offset = offset;
    }
}
