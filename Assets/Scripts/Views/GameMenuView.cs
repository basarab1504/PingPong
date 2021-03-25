using UnityEngine;
using UnityEngine.UI;

class GameMenuView : SimpleMenu
{
    [SerializeField] private Text upScore;
    [SerializeField] private Text downScore;
    [SerializeField] private Text highScore;

    public void SetUpPlayerScore(float value)
    {
        upScore.text = value.ToString();
    }

    public void SetDownPlayserScore(float value)
    {
        downScore.text = value.ToString();
    }

    public void SetHighScore(float value)
    {
        highScore.text = value.ToString();
    }
}
