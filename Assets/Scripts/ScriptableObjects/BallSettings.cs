using UnityEngine;

[CreateAssetMenu(fileName = "BallSettings", menuName = "ScriptableObjects/BallSettings")]
public class BallSettings : ScriptableObject, ISerializeable<BallData>
{
    public float R { get; set; }
    public float G { get; set; }
    public float B { get; set; }

    public Color Color => new Color(R, G, B, 100);

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
