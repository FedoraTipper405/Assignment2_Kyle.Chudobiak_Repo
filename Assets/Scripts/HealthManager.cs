using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;
    public float health;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    public void AddHealth(float value)
    {
        health += value;
        Debug.Log("Current Health: " + health);
    }
    public void ReduceHealth(float value)
    {
        health -= value;
        Debug.Log("Current Health: " + health);
    }
}
