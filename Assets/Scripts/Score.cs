using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    public void UpdateScore(Racket racket)
    {
        text.text = racket.Score.ToString();
    }
}
