using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour, ITouched
{
    public abstract void ObjectTouched();
}
