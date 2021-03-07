using UnityEngine;

[CreateAssetMenu(fileName = "HighScore", menuName = "ScriptableObjects/HighScore")]
public class HighScore : ScriptableObject
{
    private int highestScore;

    public int HighhestScore => highestScore;

    public IntEvent HighestScoreUpdated;

    public void ScoreUpdated(int score)
    {
        Debug.Log("Og");
        if (score > highestScore)
        {
            highestScore = score;
            HighestScoreUpdated.Invoke(highestScore);
        }
    }
}
