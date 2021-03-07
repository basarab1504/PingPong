using UnityEngine;

public class Player : MonoBehaviour
{
    private int score;

    public FloatEvent ScoreUpdated;

    public int Score
    {
        get => score;
        set
        {
            score = value;
            ScoreUpdated.Invoke(score);
        }
    }
}
