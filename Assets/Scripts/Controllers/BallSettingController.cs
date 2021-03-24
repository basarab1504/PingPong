using UnityEngine;

public class BallSettingController : MonoBehaviour
{
    [SerializeField] BallSettings ballSettings;
    [SerializeField] MenuManager menuManager;
    SettingsMenuView view;

    private void Awake()
    {
        view = GetComponent<SettingsMenuView>();
        view.OnColorChangeColor(ballSettings.Color);
    }

    public void OnRedColorChange(float value)
    {
        ballSettings.R = value;
        view.OnColorChangeColor(ballSettings.Color);
    }

    public void OnGreenColorChange(float value)
    {
        ballSettings.G = value;
        view.OnColorChangeColor(ballSettings.Color);
    }

    public void OnBlueColorChange(float value)
    {
        ballSettings.B = value;
        view.OnColorChangeColor(ballSettings.Color);
    }

    public void OnBackButtonClick()
    {
        menuManager.Show("Main");
    }
}
