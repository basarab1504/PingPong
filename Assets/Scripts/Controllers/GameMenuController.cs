using UnityEngine;
using UnityEngine.SceneManagement;

class GameMenuController : MonoBehaviour
{
    private GameMenuView view;
    [SerializeField] private HighScore scoreSettings;

    private void Awake()
    {
        view = GetComponent<GameMenuView>();
        OnHighScoreChange(scoreSettings.HighScoreValue);
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
