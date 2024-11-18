using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorLock : MonoBehaviour
{
    //Locks the cursor to screen and makes the cursor invisible.
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
