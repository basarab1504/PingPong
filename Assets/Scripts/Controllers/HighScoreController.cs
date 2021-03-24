using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour
{
    [SerializeField] private HighScore highScore;
    private Text text;

    private void Awake()
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
