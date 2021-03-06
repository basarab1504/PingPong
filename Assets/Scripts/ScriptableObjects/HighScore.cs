using UnityEngine;

[CreateAssetMenu(fileName = "HighScore", menuName = "ScriptableObjects/HighScore")]
public class HighScore : ScriptableObject, ISerializeable<ScoreData>
{
    [SerializeField] private int highScore;

    public int HighScoreValue
    {
        get => highScore;
        set 
        {
            highScore = value;
            HighScoreUpdated.Invoke(highScore);
        }
    }

    public IntEvent HighScoreUpdated;

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
