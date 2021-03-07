﻿using UnityEngine;
using UnityEngine.UI;

public class HighScoreObserver : MonoBehaviour
{
    private Text text;
    [SerializeField] private HighScore highScore;

    private void Start()
    {
        text = GetComponent<Text>();
        text.text = highScore.HighhestScore.ToString();
        highScore.HighestScoreUpdated.AddListener(HighestScoreUpdated);
    }

    public void HighestScoreUpdated(int score)
    {
        text.text = score.ToString();
    }
}