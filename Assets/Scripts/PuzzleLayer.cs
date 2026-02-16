using UnityEngine;

public class PuzzleLayer : MonoBehaviour
{
    public int layerIndex; // assign the layer number in Inspector
    private bool completed = false;

    public void TryComplete()
    {
        if (completed) return;

        // GameManager will ignore if this layer isn't current
        completed = true;
        GameManager.Instance.CompleteLayer(layerIndex);
    }
}
