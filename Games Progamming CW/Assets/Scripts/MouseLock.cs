using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour {
    void DidLockCursor() {
        Debug.Log("Locking cursor");
        GetComponent<GUITexture>().enabled = false;
    }
    void DidUnlockCursor() {
        Debug.Log("Unlocking cursor");
        GetComponent<GUITexture>().enabled = true;
    }
    void OnMouseDown() {
        Screen.lockCursor = true;
    }
    public static bool lockCursor = true; // Set this to enable/disable the lock.
void Update()
{
    if (Screen.lockCursor != lockCursor)
    {
        if (lockCursor && Input.GetMouseButton(0))
            Screen.lockCursor = true;
        else if (!lockCursor)
            Screen.lockCursor = false;
    }
}
}