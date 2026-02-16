using UnityEngine;

public class Layer5UpsideDown : MonoBehaviour
{
    private bool completed = false;

    void Update()
    {
        if (completed) return;

        // Check if painting is upside down
        if (Vector3.Dot(transform.up, Vector3.down) > 0.9f)
        {
            completed = true;
            GameManager.Instance.CompleteLayer(4);
        }
    }
}
