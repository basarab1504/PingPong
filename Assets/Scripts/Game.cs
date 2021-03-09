using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private BallSettings ballSettings;
    [SerializeField] private HighScore scoreSettings;

    IFileDataProvider provider = new JsonDataProvider();

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (provider.TryLoad<BallData>("ballsettings", out BallData ballData))
            ballSettings.Load(ballData);
        if (provider.TryLoad<ScoreData>("highScore", out ScoreData scoreData))
            scoreSettings.Load(scoreData);
    }

    private void OnDestroy()
    {
        provider.Save<BallData>("ballsettings", ballSettings.Save());
        provider.Save<ScoreData>("highScore", scoreSettings.Save());
    }
}
