using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private static Game game;

    private void Awake()
    {
        if (game == null)
            new GameObject().AddComponent<Game>();
    }
}
