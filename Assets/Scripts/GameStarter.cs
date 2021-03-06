using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Game gamePrefab;
    private static Game game;

    private void Awake()
    {
        if (game == null)
        {
            game = Instantiate(gamePrefab);
        }
    }
}
