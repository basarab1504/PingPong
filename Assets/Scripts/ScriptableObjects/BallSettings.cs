using UnityEngine;

[CreateAssetMenu(fileName = "BallSettings", menuName = "ScriptableObjects/BallSettings")]
public class BallSettings : ScriptableObject, ISerializeable<BallData>
{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private float minRadius;
    [SerializeField] private float maxRadius;

    public float R { get; set; }
    public float G { get; set; }
    public float B { get; set; }

    public Color Color => new Color(R, G, B, 100);

    public float MinSpeed => minSpeed;
    public float MaxSpeed => maxSpeed;
    public float MinRadius => minRadius;
    public float MaxRadius => maxRadius;

    public void Load(BallData data)
    {
        R = data.R;
        G = data.G;
        B = data.B;
    }

    public BallData Save()
    {
        return new BallData()
        {
            R = R,
            G = G,
            B = B,            
        };
    }
}
