using UnityEngine;
using UnityEngine.UI;

public class BallSettingUIManager : MonoBehaviour
{
    [SerializeField] private Slider r;
    [SerializeField] private Slider g;
    [SerializeField] private Slider b;
    [SerializeField] private BallSettings settings;

    private void Awake()
    {
        r.value = settings.R;
        g.value = settings.G;
        b.value = settings.B;
    }
}
