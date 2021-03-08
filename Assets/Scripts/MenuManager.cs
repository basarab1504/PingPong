using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Load(int sceneIdx)
    {
        SceneManager.LoadScene(sceneIdx);
    }
}
