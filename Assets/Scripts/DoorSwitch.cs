using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorSwitch : InteractableObject
{
    public UnityEvent OpenDoor;
    public override void ObjectTouched()
    {
        OpenDoor.Invoke();
        Debug.Log("Door opened");
    }
}
