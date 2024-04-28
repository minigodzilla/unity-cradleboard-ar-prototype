using UnityEngine;

public class OpacityController : MonoBehaviour
{
    public float opacity = 1f; // Default opacity value (1f = fully opaque, 0f = fully transparent)

    void Start()
    {
        SetOpacity(opacity);
    }

    public void SetOpacity(float value)
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();

        foreach (Renderer renderer in renderers)
        {
            foreach (Material material in renderer.materials)
            {
                Color color = material.color;
                color.a = value;
                material.color = color;
            }
        }
    }
}
