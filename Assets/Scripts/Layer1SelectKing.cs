using UnityEngine;

public class Layer1SelectKing : MonoBehaviour
{
    public GameManager gameManager;
    private bool completed = false;

    void OnMouseDown()
    {
        if (completed) return;

        // Only allow if this is the current active layer
        if (gameManager != null && gameManager.CurrentLayer == 0)
        {
            completed = true;

            gameManager.CompleteLayer(0);
        }
    }
}
