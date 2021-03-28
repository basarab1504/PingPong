using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private MenuManager manager;

    private void Awake()
    {
        manager.Show("Main");
    }
}
