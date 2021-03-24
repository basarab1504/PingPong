using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] MenuManager menuManager;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings()
    {
        menuManager.Show("Settings");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}