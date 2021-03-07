using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Racket up;
    [SerializeField] private Racket down;

    public void DefineScore(Ball ball)
    {
        if (ball.transform.position.y > 0)
            down.Score++;
        else
            up.Score++;
    }
}
