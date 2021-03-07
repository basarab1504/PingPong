using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Racket up;
    [SerializeField] private Racket down;

    public void DefineScore(Ball ball)
    {
        if (ball.transform.position.y > 0)
            up.Score++;
        else
            down.Score++;
    }
}
