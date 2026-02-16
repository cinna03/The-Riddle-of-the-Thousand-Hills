using UnityEngine;

public class Layer4LightSwitch : MonoBehaviour
{
    public Light targetLight; // drag the light object here
    private bool completed = false;

    void Update()
    {
        if (completed) return;

        // If light is turned off (example condition), layer is solved
        if (targetLight != null && targetLight.intensity < 0.5f)
        {
            completed = true;
            GameManager.Instance.CompleteLayer(3);
        }
    }
}
