using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private Player[] players;
    private float currentAxis;
    private HighScore scoreSettings;

    public IntEvent HighScoreChanged;
    public IntEvent UpScoreChanged;
    public IntEvent DownScoreChanged;

    private void Awake()
    {

    }

    public void CountScore(Player player)
    {
        player.Score++;

        if (player.Score > scoreSettings.HighScoreValue)
            scoreSettings.HighScoreValue = player.Score;
    }
}
