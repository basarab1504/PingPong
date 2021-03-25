using UnityEngine;

[CreateAssetMenu(fileName = "HighScore", menuName = "ScriptableObjects/HighScore")]
public class HighScore : ScriptableObject, ISerializeable<ScoreData>
{
    private int highScore;

    public int HighScoreValue
    {
        get => highScore;
        set 
        {
            highScore = value;
        }
    }

    public void Load(ScoreData data)
    {
        highScore = data.highScore;
    }

    public ScoreData Save()
    {
        return new ScoreData()
        {
            highScore = highScore
        };
    }
}
