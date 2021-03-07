using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player up;
    [SerializeField] private Player down;

    public void DefineScore(Ball ball)
    {
        if (ball.transform.position.y > 0)
            down.Score++;
        else
            up.Score++;
    }
}
