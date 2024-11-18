using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float PlayerSpeed;
    [SerializeField] private Rigidbody rb;

    private IMovementInput _movementInput = null;

    public Transform ThirdPersonCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Grabs IMovementInput component to gain access to private fields.
    private void Awake()
    {
        _movementInput = GetComponent<IMovementInput>();
    }

    //Assigns local variables with the IMovementInput inputs.
    //Moves character using the local variable inputs.
    void FixedUpdate()
    {
        var horizontalInput = _movementInput.HorizontalInput;
        var verticalInput = _movementInput.VerticalInput;

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput).normalized;

        //Uses ThirdPersonCamera to change the rotation of the player based on where the camera is facing.
        float downwardVelocity = rb.velocity.y;
        rb.velocity = (direction.x * ThirdPersonCamera.right + direction.z * ThirdPersonCamera.forward).normalized * PlayerSpeed * Time.deltaTime;
        rb.velocity = new Vector3(rb.velocity.x, downwardVelocity, rb.velocity.z);
    }
}
