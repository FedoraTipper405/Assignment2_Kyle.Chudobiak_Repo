using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObject : MonoBehaviour
{
    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
