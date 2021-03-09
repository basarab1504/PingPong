using System;
using UnityEngine;

[Serializable]
public struct BallData
{
    public float R;
    public float G;
    public float B;

    public Color Color => new Color(R, G, B, 100);
}
