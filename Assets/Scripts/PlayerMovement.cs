using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] public float speedMultiplier;
    void Start()
    {
        
    }

   
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speedMultiplier);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speedMultiplier);
    }
}
