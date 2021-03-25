using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private HighScore scoreSettings;

    public IntEvent HighScoreChanged;

    public void CountScore(Player player)
    {
        player.Score++;
        
        if (player.Score > scoreSettings.HighScoreValue)
        {
            scoreSettings.HighScoreValue = player.Score;
            HighScoreChanged.Invoke(scoreSettings.HighScoreValue);
        }
    }
}
