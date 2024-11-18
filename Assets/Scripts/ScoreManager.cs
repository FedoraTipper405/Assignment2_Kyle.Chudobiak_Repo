using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public float Score;

    //Creates an Instance of the ScoreManager.
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    //Adds score whenever a coin is collected by the player.
    public void AddPoint(float value)
    {
        Score += value;
        Debug.Log("Current Score: " + Score);
    }
}
