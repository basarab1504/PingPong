using UnityEngine;

[CreateAssetMenu(fileName = "HighScore", menuName = "ScriptableObjects/HighScore")]
public class HighScore : ScriptableObject
{
    private int highestScore;

    public int HighhestScore => highestScore;

    public IntEvent HighestScoreUpdated;

    public void Load(ScoreData data)
    {
        highestScore = data.HighScore;
    }

    public ScoreData Save()
    {
        return new ScoreData()
        {
            HighScore = highestScore
        };
    }

    public void ScoreUpdated(int score)
    {
        if (score > highestScore)
        {
            highestScore = score;
            HighestScoreUpdated.Invoke(highestScore);
        }
    }
}
