using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Heart : InteractableObject
{
    public InteractableObjectData _interactableObjectData;
    public float HeartValue => _interactableObjectData._objectValue;
    
    public UnityEvent HeartGrabbed;
    public void ItemTouched()
    {
        HeartGrabbed.Invoke();
    }

    public override void ObjectTouched()
    {
        Debug.Log("Heart grabbed");
        HealthManager.Instance.AddHealth(HeartValue);
        ItemTouched();
    }
}
