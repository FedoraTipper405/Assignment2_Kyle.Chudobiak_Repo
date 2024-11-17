using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : InteractableObject
{
    public InteractableObjectData _interactableObjectData;
    public float CoinValue => _interactableObjectData._objectValue;

    public UnityEvent CoinGrabbed;
    public void ItemTouched()
    {
        CoinGrabbed.Invoke();
    }

    public override void ObjectTouched()
    {
        Debug.Log("Coin grabbed");
        ScoreManager.Instance.AddPoint(CoinValue);
        ItemTouched();
    }
}
