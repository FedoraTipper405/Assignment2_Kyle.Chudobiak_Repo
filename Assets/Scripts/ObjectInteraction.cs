using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<ITouched>() != null)
        {
            collision.gameObject.GetComponent<ITouched>().ObjectTouched();
        }
    }
}
