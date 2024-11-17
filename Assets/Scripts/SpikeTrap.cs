using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : InteractableObject
{
    public InteractableObjectData _interactableObjectData;
    public float SpikeTrapValue => _interactableObjectData._objectValue;
    public override void ObjectTouched()
    {
        Debug.Log("Ouch!!!!");
        HealthManager.Instance.ReduceHealth(SpikeTrapValue);
    }
}
