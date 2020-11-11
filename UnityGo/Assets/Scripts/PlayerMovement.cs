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
    [SerializeField] private GameObject playerGround;
    private Collider2D gcol;
    public bool canJump;

    private Rigidbody2D rb;
    private Collider2D col;

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
        gcol = playerGround.GetComponent<Collider2D>();
        canJump = false;
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
        //distToGround = col.bounds.extents.y;
        playerActionControls.Land.Jump.performed += _ => Jump();
    }

    private void Jump()
    {
        if(canJump)
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            canJump = false;
        }
    }


/*
    void OnCollisionStay2D(Collision2D col) {
 
        if (col.gameObject.tag != "Ground")
        {
            canJump = true;
        }
    }

    private bool IsGrounded()
    {
        //int layerMask = 1 << 8;     
        //return Physics2D.Raycast(col.bounds.center, Vector2.down * 0.1f, col.bounds.extents.y + 0.1f, layerMask);
        return Physics.Raycast(col.bounds.center,Vector2.down, col.bounds.extents.y);
        if(Physics.Raycast(col.bounds.center,Vector2.down, col.bounds.extents.y)) { 
            if (col.gameObject.tag == "Ground") {UnityEngine.Debug.DrawRay(transform.position, transform.forward, Color.green); print("Hit"); } }
    }
*/


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
