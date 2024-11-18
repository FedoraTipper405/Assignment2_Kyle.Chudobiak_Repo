using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private bool _canMove;
    private bool _stopDoorMovement;

    void Start()
    {
        _canMove = false;
        _stopDoorMovement = false;
    }

    //Sets bool to true whenever the UnityEvent is invoked from door switch.
    public void EnableDoorMovement()
    {
        _canMove = true;
    }

    //Moves Doors tranfoprm up for 2 seconds,
    private IEnumerator MoveTimer()
    {
        transform.Translate(transform.up * Time.deltaTime);
        yield return new WaitForSeconds(2);
        _canMove = false;
        _stopDoorMovement = true;
    }

    //Checks if coroutine can be played by checking if the _canMove bool is true and the _stopDoorMovement bool is false.
    void Update()
    {
        if (_canMove && _stopDoorMovement == false)
        {
            StartCoroutine(MoveTimer());
        }
    }
}
