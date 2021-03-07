using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    public void UpdateScore(float score)
    {
        text.text = score.ToString();
    }
}
