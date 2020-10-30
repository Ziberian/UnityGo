using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerActionControls playerActionControls;

    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float jumpSpeed = 5.0f;
    [SerializeField] private LayerMask ground;

    private Rigidbody2D rb;
    private Collider2D col;
   

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
    }

    private void OnEnable()
    {
        playerActionControls.Enable();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerActionControls.Land.Jump.performed += _ => Jump();
    }

    private void Jump()
    {
        if(IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        Vector2 feetPos = transform.position;
        feetPos.y -= col.bounds.extents.y;
        return Physics2D.OverlapCircle(feetPos, .1f, ground);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //read the movement value
        float movementInput = playerActionControls.Land.Move.ReadValue<float>();

        //move player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * speed * Time.deltaTime;
        transform.position = currentPosition;

    }
}
