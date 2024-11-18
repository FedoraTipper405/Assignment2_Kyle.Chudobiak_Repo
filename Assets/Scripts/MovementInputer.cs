using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInputer : MonoBehaviour, IMovementInput
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    public void Update()
    {
        GetInput();
    }
    public void GetInput()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
    }
}
