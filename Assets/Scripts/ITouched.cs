using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITouched
{
    void ObjectTouched();
}

public interface ISpikeTrapHit
{
    void PlayerHitsTrap();
}
