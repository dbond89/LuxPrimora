using UnityEngine;


public class CharMovement : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _playerVelocity;
    [SerializeField] float speed;
    [SerializeField] float gravity;
    public ChildMoveChecker mvLeft;
    public ChildMoveChecker mvRight;
    public ChildMoveChecker mvUp;
    public ChildMoveChecker mvDown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.SimpleMove(movement * speed);

    }

    private bool CanGoLeft() { return !mvLeft.IsColliding(); }

    private bool CanGoRight() { return !mvRight.IsColliding(); }

    private bool CanGoUp() { return !mvUp.IsColliding(); }

    private bool CanGoDown() { return !mvDown.IsColliding(); }
}
