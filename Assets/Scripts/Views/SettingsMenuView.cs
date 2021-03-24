using UnityEngine;
using UnityEngine.UI;

class SettingsMenuView : SimpleMenu
{
    [SerializeField] private Slider r;
    [SerializeField] private Slider g;
    [SerializeField] private Slider b;
    [SerializeField] private Image ballColor;

    public void OnColorChangeColor(Color color)
    {
        r.value = color.r;
        g.value = color.g;
        b.value = color.b;
        ballColor.color = color;
    }
}