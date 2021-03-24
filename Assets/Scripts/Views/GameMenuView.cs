using UnityEngine;
using UnityEngine.UI;

class GameMenuView : SimpleMenu
{
    [SerializeField] private Text score1;
    [SerializeField] private Text score2;
    [SerializeField] private Text highScore;

    public void SetPlayerOneScore(float value)
    {
        score1.text = value.ToString();
    }

    public void SetPlayerTwoScore(float value)
    {
        score2.text = value.ToString();
    }

    public void SetHighScore(float value)
    {
        highScore.text = value.ToString();
    }
}
