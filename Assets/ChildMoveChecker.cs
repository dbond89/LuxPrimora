using System;
using Unity.VisualScripting;
using UnityEngine;

public class ChildMoveChecker : MonoBehaviour
{
    private bool _colliding;
    private Collider _collider;

    private void Start()
    {
        _collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider c) { _colliding = true; }

    private void OnTriggerExit(Collider c) { _colliding = false; }

    public bool IsColliding()
    {
        return _colliding;
    }
}
