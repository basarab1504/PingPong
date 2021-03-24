using UnityEngine;
using UnityEngine.SceneManagement;

class GameMenuController : MonoBehaviour
{
    private GameMenuView view;

    private void Awake()
    {
        view = GetComponent<GameMenuView>();
    }

    public void OnFirstPlayerScoreChange(float value)
    {
        view.SetPlayerOneScore(value);
    }

    public void OnSecondPlayerScoreChange(float value)
    {
        view.SetPlayerTwoScore(value);
    }

    public void OnExitButtonClick()
    {
        SceneManager.LoadScene(0);
    }
}
