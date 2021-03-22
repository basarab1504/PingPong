using UnityEngine;
using UnityEngine.UI;

public class ColorPickerImage : MonoBehaviour
{
    [SerializeField] private BallSettings settings;
    private Image image;
    private Color color;

    private void Awake()
    {
        color = new Color(settings.R, settings.G, settings.B);
        image = GetComponent<Image>();
        image.color = color;
    }

    private void Update()
    {
        if (settings.Color != color)
        {
            color = settings.Color;
            image.color = color;
        }
    }
}
