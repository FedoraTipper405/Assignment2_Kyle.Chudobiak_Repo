using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    //Whenever the player collides with an object, it checks if touched object has the ITouched interface.
    //If object has said interface, it will play the interfaces method.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<ITouched>() != null)
        {
            collision.gameObject.GetComponent<ITouched>().ObjectTouched();
        }
    }
}
