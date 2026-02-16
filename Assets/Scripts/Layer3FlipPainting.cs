using UnityEngine;

public class Layer3FlipPainting : MonoBehaviour
{
    private bool completed = false;

    void Update()
    {
        if (completed) return;

        // Check if painting is flipped backward
        if (Vector3.Dot(transform.forward, Vector3.forward) < -0.9f)
        {
            completed = true;
            GameManager.Instance.CompleteLayer(2);
        }
    }
}
