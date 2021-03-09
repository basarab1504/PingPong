using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private BallSettings ballSettings;
    [SerializeField] private HighScore scoreSettings;

    IFileDataProvider provider = new JsonDataProvider();

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        ballSettings.Load(provider.Load<BallData>("ballsettings"));
        scoreSettings.Load(provider.Load<ScoreData>("highScore"));
    }

    private void OnDestroy()
    {
        provider.Save<BallData>("ballsettings", ballSettings.Save());
        provider.Save<ScoreData>("highScore", scoreSettings.Save());
    }
}
