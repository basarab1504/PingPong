using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int highScore;

    public IntEvent HighScoreChanged;

    private void Awake()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("highScore", highScore);
    }

    public void CountScore(Player player)
    {
        player.Score++;
        
        if (player.Score > highScore)
        {
            highScore = player.Score;
            HighScoreChanged.Invoke(highScore);
        }
    }
}
