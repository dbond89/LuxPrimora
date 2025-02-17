using UnityEngine;
using System.Collections;

public class CharMovement : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _playerVelocity;
    [SerializeField] float _speed = 2.0f;
    [SerializeField] float _gravity = -9.81f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.SimpleMove(movement * _speed);
    }
}
