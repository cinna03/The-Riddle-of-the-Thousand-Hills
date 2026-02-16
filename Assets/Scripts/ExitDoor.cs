using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    private bool unlocked = false;

    public void UnlockDoor()
    {
        unlocked = true;
        Debug.Log("Door Unlocked!");
    }

    public void OpenDoor()
    {
        if (!unlocked) return;

        transform.Rotate(0, 90, 0);
    }
}
