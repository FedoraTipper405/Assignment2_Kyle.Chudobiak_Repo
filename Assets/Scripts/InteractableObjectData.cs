using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InteractableObjectData", menuName = "SOs/InteractableObjectData")]
public class InteractableObjectData : ScriptableObject
{
    [SerializeField] public float _objectValue;
}
