using System;
using Unity.VisualScripting;
using UnityEngine;

public class ChildMoveChecker : MonoBehaviour
{
    private bool _colliding;
    private BoxCollider _collider;

    private void Start()
    {
        _collider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider c)
    {
        _colliding = true;
        print(this.name + " Trigger entered");
    }

    private void OnTriggerExit(Collider c)
    {
        _colliding = false;
        print(this.name +" sTrigger exited");
    }

    public bool IsColliding()
    {
        return _colliding;
    }
}
