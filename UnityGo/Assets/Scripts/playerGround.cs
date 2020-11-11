using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGround : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public GameObject player;
    private Collider2D collider;

   private void OnEnable()
    {
        collider = GetComponent<Collider2D>();
    }

    void OnCollisionStay2D(Collision2D col) 
    {
        Physics2D.IgnoreCollision(collider, player.GetComponent<Collider2D>());
        playerMovement.canJump = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
