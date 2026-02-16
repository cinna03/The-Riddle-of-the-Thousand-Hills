using UnityEngine;

public class Layer2PlaceOnTable : MonoBehaviour
{
    [Header("Settings")]
    public string requiredObjectName = "MwamiPainting";
    public Vector3 placementOffset = new Vector3(0, 0.5f, 0);

    private bool completed = false;

    // Prevent immediate trigger on start
    private bool ready = false;

    private void Start()
    {
        // Delay enabling trigger detection for 0.1 seconds
        Invoke(nameof(EnableTrigger), 0.1f);
    }

    private void EnableTrigger()
    {
        ready = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!ready || completed)
            return;

        if (other.gameObject.name == requiredObjectName)
        {
            completed = true;

            // Snap painting to table center
            other.transform.position = transform.position + placementOffset;
            other.transform.rotation = Quaternion.identity;

            // Make Rigidbody kinematic so it stays in place
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;
                rb.useGravity = false;
            }

            // Notify GameManager that Layer 2 is complete
            GameManager.Instance.CompleteLayer(1);
        }
    }
}
