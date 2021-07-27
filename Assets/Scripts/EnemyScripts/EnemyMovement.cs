using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public GameObject player;
    float playerDis = 4;
    Animator anim;


    void Awake()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        playerDis = Vector3.Distance(transform.position, player.transform.position); // Check distance between enemy and player;
        //print("Distance between player and enemy " + playerDis);
        EnemyMove();
    }

    private void EnemyMove()
    {    
        if (playerDis <= 4)
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("moveX", (player.transform.position.x - transform.position.x));
            anim.SetFloat("moveY", (player.transform.position.y - transform.position.y));
            //print("Player Detected");
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime); // Move towards player
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        int move = Random.Range(1, 5);
        // If the enemy is on top of one another during spawn, move 5 spaces away
        if (other.gameObject.tag == "Enemy")
        {
            transform.Translate(move, move, 0);
        }
    }
}
