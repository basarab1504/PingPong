using UnityEngine;

public class Player : MonoBehaviour
{
    private int score;

    public IntEvent ScoreUpdated;

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
