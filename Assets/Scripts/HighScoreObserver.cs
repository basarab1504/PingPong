using UnityEngine;
using UnityEngine.UI;

public class HighScoreObserver : MonoBehaviour
{
    private Text text;
    [SerializeField] private HighScore highScore;

    private void Start()
    {
        text = GetComponent<Text>();

        HighestScoreUpdated(highScore.HighScoreValue);
        
        highScore.HighScoreUpdated.AddListener(HighestScoreUpdated);
    }

    private void HighestScoreUpdated(int score)
    {
        text.text = score.ToString();
    }
}
