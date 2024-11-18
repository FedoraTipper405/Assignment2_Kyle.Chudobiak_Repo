using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : InteractableObject
{
    public InteractableObjectData InteractableObjectData;
    public float CoinValue => InteractableObjectData.ObjectValue;

    public UnityEvent CoinGrabbed;
    
    //Invokes UnityEvent whenever the coin has been touched by the player.
    public void CoinTouched()
    {
        CoinGrabbed.Invoke();
    }

    //Accesses the ScoreManagers AddPoint function to add a point to the score.
    //Plays CoinTouched funtion to invoke CoinGrabbed UnityEvent.
    public override void ObjectTouched()
    {
        Debug.Log("Coin grabbed");
        ScoreManager.Instance.AddPoint(CoinValue);
        CoinTouched();
    }
}
