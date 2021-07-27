using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDisappear : MonoBehaviour
{
    public GameObject door;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {       
        door.SetActive(true);
        wall.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            door.SetActive(false);
            wall.SetActive(true);
        }
    }
}
