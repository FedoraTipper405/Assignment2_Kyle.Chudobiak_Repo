using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : InteractableObject, ISpikeTrapHit
{
    public InteractableObjectData _interactableObjectData;
    public float SpikeTrapValue => _interactableObjectData._objectValue;
    public override void ObjectTouched()
    {
        HealthManager.Instance.ReduceHealth(SpikeTrapValue);
        PlayerHitsTrap();
    }
    public void PlayerHitsTrap()
    {
        Debug.Log("Ouch!!!!");
    }
}
