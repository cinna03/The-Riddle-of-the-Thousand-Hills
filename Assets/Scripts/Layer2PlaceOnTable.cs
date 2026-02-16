using UnityEngine;

public class Layer2PlaceOnTable : MonoBehaviour
{
    public string requiredObjectName = "MwamiPainting";
    private bool completed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (completed) return;

        if (other.gameObject.name == requiredObjectName)
        {
            completed = true;
            GameManager.Instance.CompleteLayer(1);
        }
    }
}
