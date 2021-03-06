using UnityEngine;

[CreateAssetMenu(fileName = "BallSettings", menuName = "ScriptableObjects/BallSettings")]
public class BallSettings : ScriptableObject, ISerializeable<BallData>
{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private float minRadius;
    [SerializeField] private float maxRadius;

    public void Load(BallData data)
    {
        minSpeed = data.minSpeed;
        maxSpeed = data.maxSpeed;
        minRadius = data.minRadius;
        maxRadius = data.maxRadius;
        R = data.R;
        G = data.G;
        B = data.B;
    }

    public BallData Save()
    {
        return new BallData()
        {
            minSpeed = minSpeed,
            maxSpeed = maxSpeed,
            minRadius = minRadius,
            maxRadius = maxRadius,
            R = R,
            G = G,
            B = B,            
        };
    }

    public float R { get; set; }
    public float G { get; set; }
    public float B { get; set; }

    public Color Color => new Color(R, G, B, 100);

    public float MinSpeed { get => minSpeed; set => minSpeed = value; }
    public float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
    public float MinRadius { get => minRadius; set => minRadius = value; }
    public float MaxRadius { get => maxRadius; set => maxRadius = value; }
}
