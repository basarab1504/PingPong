using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    [SerializeField] Player player;

    public PlayerEvent Scored;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Scored.Invoke(player);
    }
}
