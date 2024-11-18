using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;
    public float PlayerHealth;

    //Creates an Instance of the HealthManager.
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    //Adds health whenever a heart is collected by the player.
    public void AddHealth(float value)
    {
        PlayerHealth += value;
        Debug.Log("Current Health: " + PlayerHealth);
    }

    //Reduces health whenever a spiketrap is touched by the player.
    public void ReduceHealth(float value)
    {
        PlayerHealth -= value;
        Debug.Log("Current Health: " + PlayerHealth);
    }
}
