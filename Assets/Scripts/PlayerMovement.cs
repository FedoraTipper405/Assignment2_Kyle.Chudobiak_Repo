using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] private Rigidbody rb;

    private IMovementInput movementInput = null;

    public Transform _camera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        movementInput = GetComponent<IMovementInput>();
    }

    void FixedUpdate()
    {
        var horizontalInput = movementInput.Horizontal;
        var verticalInput = movementInput.Vertical;

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput).normalized;

       
        float downwardVelocity = rb.velocity.y;
        rb.velocity = (direction.x * _camera.right + direction.z * _camera.forward).normalized * speed * Time.deltaTime;
        rb.velocity = new Vector3(rb.velocity.x, downwardVelocity, rb.velocity.z);
    }
}
