using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    public bool canMove;
    Animator anim;

    Rigidbody2D rb;

    Vector2 movePlayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        canMove = true;
    }

    void Update()
    {
        if(canMove == true)
        {
            // Movement
            movePlayer.x = Input.GetAxis("Horizontal");
            movePlayer.y = Input.GetAxis("Vertical");

            // Animation
            anim.SetFloat("Horizontal", movePlayer.x);
            anim.SetFloat("Vertical", movePlayer.y);
            anim.SetFloat("Speed", movePlayer.sqrMagnitude);
        }
        else
        {
            print("Can't Move");
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movePlayer * speed * Time.fixedDeltaTime);
    }
}
