using UnityEngine;

public class FieldAdjuster : MonoBehaviour
{
    [SerializeField] private BoxCollider2D playField;
    [SerializeField] private BoxCollider2D wallLeft;
    [SerializeField] private BoxCollider2D wallRight;
    [SerializeField] private BoxCollider2D zoneUp;
    [SerializeField] private BoxCollider2D zoneDown;
    private Vector2 lastCheckedCameraSize;

    private void Start()
    {
        lastCheckedCameraSize = GetCameraSize();
        AdjustBorders(lastCheckedCameraSize);
    }

    private void FixedUpdate()
    {
        if (lastCheckedCameraSize != GetCameraSize())
        {
            lastCheckedCameraSize = GetCameraSize();
            AdjustBorders(lastCheckedCameraSize);
        }
    }

    private Vector2 GetCameraSize()
    {
        Camera camera = Camera.main;

        var height = 2f * camera.orthographicSize;
        var width = height * camera.aspect;

        return new Vector2(width, height);
    }

    private void AdjustBorders(Vector2 cameraSize)
    {
        playField.size = cameraSize;

        Vector2 wallSize = new Vector2(0.1f, cameraSize.y);
        Vector2 wallOffset = new Vector2(cameraSize.x * 0.5f, 0);

        Adjust(wallRight, wallSize, wallOffset);
        Adjust(wallLeft, wallSize, -wallOffset);

        Vector2 zoneSize = new Vector2(cameraSize.x, 0.5f);
        Vector2 zoneOffset = new Vector2(0, cameraSize.y * 0.5f);

        Adjust(zoneUp, zoneSize, zoneOffset);
        Adjust(zoneDown, zoneSize, -zoneOffset);
    }

    private void Adjust(BoxCollider2D collider2D, Vector2 size, Vector2 offset)
    {
        collider2D.size = size;
        collider2D.offset = offset;
    }
}
