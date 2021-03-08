using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private BallSettings ballSettings;
    [SerializeField] private HighScore scoreSettings;

    IFileDataProvider provider = new XMLDataProvider();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        ballSettings.Load(provider.Load<BallData>("ballsettings.xml"));
        scoreSettings.Load(provider.Load<ScoreData>("highScore.xml"));
    }

    private void OnDestroy()
    {
        provider.Save<BallData>("ballsettings.xml", ballSettings.Save());
        provider.Save<ScoreData>("highScore.xml", scoreSettings.Save());
    }
}
