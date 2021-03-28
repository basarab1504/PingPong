using UnityEngine;
using UnityEngine.SceneManagement;

class GameMenuController : MonoBehaviour
{
    private GameMenuView view;

    private void Awake()
    {
        view = GetComponent<GameMenuView>();
        OnHighScoreChange(PlayerPrefs.GetInt("highScore", 0));
    }

    public void OnUpPlayerScoreChange(int value)
    {
        view.SetUpPlayerScore(value);
    }

    public void OnDownPlayerScoreChange(int value)
    {
        view.SetDownPlayserScore(value);
    }

    public void OnHighScoreChange(int value)
    {
        view.SetHighScore(value);
    }

    public void OnExitButtonClick()
    {
        SceneManager.LoadScene(0);
    }
}
