using UnityEngine;

[CreateAssetMenu(fileName = "BallSettings", menuName = "ScriptableObjects/BallSettings")]
public class BallSettings : ScriptableObject
{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private float minRadius;
    [SerializeField] private float maxRadius;

    public float MinSpeed { get => minSpeed; set => minSpeed = value; }
    public float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
    public float MinRadius { get => minRadius; set => minRadius = value; }
    public float MaxRadius { get => maxRadius; set => maxRadius = value; }
}
