using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.constraints = Rigidbody2D.FreezeRotation;
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            //rb.constraints = Rigidbody2D.FreezePositionX;
            //rb.constraints = Rigidbody2D.FreezeRotation;
        }
    }
}
