using UnityEngine;

public class CanvasSwitch : MonoBehaviour
{
    [SerializeField] private Canvas to;
    Canvas from;

    private void Awake()
    {
        from = GetComponent<Canvas>();
    }

    public void Switch()
    {
        from.enabled = false;
        to.enabled = true;
    }
}
