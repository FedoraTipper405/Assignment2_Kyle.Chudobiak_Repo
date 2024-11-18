using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInputer : MonoBehaviour, IMovementInput
{
    public float HorizontalInput { get; private set; }
    public float VerticalInput { get; private set; }

    public void Update()
    {
        GetInput();
    }

    //Sets the Inputs using unity legacy inputs.
    public void GetInput()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }
}
