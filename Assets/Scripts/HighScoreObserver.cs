using UnityEngine;
using UnityEngine.UI;

public class HighScoreObserver : MonoBehaviour
{
    private Text text;
    [SerializeField] private HighScore highScore;

    private void Start()
    {
        text = GetComponent<Text>();
        text.text = highScore.HighScoreValue.ToString();
        highScore.HighScoreUpdated.AddListener(HighestScoreUpdated);
    }

    public void HighestScoreUpdated(int score)
    {
        text.text = score.ToString();
    }
}
