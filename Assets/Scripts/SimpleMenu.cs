using UnityEngine;

class SimpleMenu : MonoBehaviour, IMenu
{
    Canvas canvas;

    public string Name => name;

    void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void Hide()
    {
        canvas.enabled = false;
    }

    public void Show()
    {
        canvas.enabled = true;
    }
}
