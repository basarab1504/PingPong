using System;
using UnityEngine;

[Serializable]
public struct BallData
{
    public float MaxSpeed { get; set; }
    public float MinSpeed { get; set; }
    public float MinRadius { get; set; }
    public float MaxRadius { get; set; }
    public float R { get; set; }
    public float G { get; set; }
    public float B { get; set; }

    public Color Color => new Color(R, G, B, 100);
}
