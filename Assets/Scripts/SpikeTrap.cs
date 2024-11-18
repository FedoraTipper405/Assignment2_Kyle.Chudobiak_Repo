using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : InteractableObject, ISpikeTrapHit
{
    public InteractableObjectData InteractableObjectData;
    public float SpikeTrapValue => InteractableObjectData.ObjectValue;

    //Plays PlayerHitsTrap funtion to display debug message.
    //Accesses the HealthManager ReduceHealth function to remove a point from PlayerHealth.
    public override void ObjectTouched()
    {
        PlayerHitsTrap();
        HealthManager.Instance.ReduceHealth(SpikeTrapValue);
    }

    //Displays message to show when the player hits the trap.
    public void PlayerHitsTrap()
    {
        Debug.Log("Ouch!!!!");
    }
}
