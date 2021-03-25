using UnityEngine;
using UnityEngine.SceneManagement;

class GameMenuController : MonoBehaviour
{
    private GameMenuView view;

    private void Awake()
    {
        view = GetComponent<GameMenuView>();
    }

    public void OnUpPlayerScoreChange(int value)
    {
        view.SetPlayerOneScore(value);
    }

    public void OnDownPlayerScoreChange(int value)
    {
        view.SetPlayerTwoScore(value);
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
