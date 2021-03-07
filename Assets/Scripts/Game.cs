using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private BallSettings ballSettings;

    DataProvider provider = new DataProvider();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        var data = provider.Load<BallData>("ballsettings.xml");
        ballSettings.Load(data);

        // provider.Load<ScoreData>("highScore.xml");
    }

    private void OnDestroy()
    {
        provider.Save<BallData>("ballsettings.xml", ballSettings.Save());
        // provider.Save<ScoreData>("highScore.xml", highScore);
    }
}
