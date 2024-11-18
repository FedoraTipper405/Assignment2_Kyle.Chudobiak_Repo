using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Heart : InteractableObject
{
    public InteractableObjectData InteractableObjectData;
    public float HeartValue => InteractableObjectData.ObjectValue;
    
    public UnityEvent HeartGrabbed;

    //Invokes UnityEvent whenever the heart has been touched by the player.
    public void HeartTouched()
    {
        HeartGrabbed.Invoke();
    }

    //Accesses the HealthManagers AddHealth function to add some points to the PlayerHealth.
    //Plays HeartTouched funtion to invoke HeartGrabbed UnityEvent.
    public override void ObjectTouched()
    {
        Debug.Log("Heart grabbed");
        HealthManager.Instance.AddHealth(HeartValue);
        HeartTouched();
    }
}
