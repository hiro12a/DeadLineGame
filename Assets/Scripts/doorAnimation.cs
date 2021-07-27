using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAnimation : MonoBehaviour
{
    Animator doorAnim;

    private void Start()
    {       
        doorAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            doorAnim.SetBool("Open", false);
            print("Open Door");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            doorAnim.SetBool("Open", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            doorAnim.SetBool("Open", false);
        }
    }
}
