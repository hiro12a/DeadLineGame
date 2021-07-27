using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProcessing : MonoBehaviour
{
    public GameObject dorm;
    public GameObject everything;

    // Start is called before the first frame update
    void Awake()
    {
        dorm.SetActive(true);
        everything.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            dorm.SetActive(false);
            everything.SetActive(true);
        }      
    }
}
