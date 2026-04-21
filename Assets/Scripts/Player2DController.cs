using UnityEngine;
using UnityEngine.InputSystem;

public class Player2DController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 450f;
    private float moveValue;
    private Rigidbody2D _rb;

    private bool _isGrounded = false;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null)
        {
            moveValue = (Keyboard.current.dKey.isPressed ? 1:0) - (Keyboard.current.aKey.isPressed ? 1:0);
        }
        _rb.linearVelocity = new Vector2(moveValue * speed, _rb.linearVelocity.y);

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _rb.AddForce(new Vector2(_rb.linearVelocityX, jumpForce));
        }

    }
}
