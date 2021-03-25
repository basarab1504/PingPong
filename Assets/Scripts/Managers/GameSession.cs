using UnityEngine;

enum Direction
{
    UP,
    DOWN
}

public class GameSession : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private Racket up;
    [SerializeField] private Racket down;
    private float currentAxis;
    private HighScore scoreSettings;

    public IntEvent HighScoreChanged;
    public IntEvent UpScoreChanged;
    public IntEvent DownScoreChanged;

    private void Update()
    {
        currentAxis = Input.GetAxis("Horizontal");
        if (currentAxis != 0)
        {
            var vector = new Vector3(currentAxis, 0, 0);
            up.Push(vector, speed);
            down.Push(vector, speed);
        }
    }

    public void CountScore(Player player)
    {
        player.Score++;

        if (player.Score > scoreSettings.HighScoreValue)
            scoreSettings.HighScoreValue = player.Score;
    }
}
