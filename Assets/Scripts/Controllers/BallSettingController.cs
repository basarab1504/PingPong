using UnityEngine;

public class BallSettingController : MonoBehaviour
{
    SettingsMenuView view;
    Color color;
    [SerializeField] MenuManager menuManager;

    private void Awake()
    {
        view = GetComponent<SettingsMenuView>();

        var r = PlayerPrefs.GetFloat("R", 0);
        var g = PlayerPrefs.GetFloat("G", 0);
        var b = PlayerPrefs.GetFloat("B", 0);

        color = new Color(r, g, b);
        
        view.OnColorChangeColor(color);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("R", color.r);
        PlayerPrefs.SetFloat("G", color.g);
        PlayerPrefs.SetFloat("B", color.b);
    }

    public void OnRedColorChange(float value)
    {
        color.r = value;
        view.OnColorChangeColor(color);
    }

    public void OnGreenColorChange(float value)
    {
        color.g = value;
        view.OnColorChangeColor(color);
    }

    public void OnBlueColorChange(float value)
    {
        color.b = value;
        view.OnColorChangeColor(color);
    }

    public void OnBackButtonClick()
    {
        menuManager.Show("Main");
    }
}
