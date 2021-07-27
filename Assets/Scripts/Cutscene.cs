using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject dialogBox;
    public Dialog dialog;

    private void Start()
    {      
        dialogBox.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            dialogBox.SetActive(true);
            Time.timeScale = 0;
            FindObjectOfType<DialogManager>().StartDialog(dialog);
            gameObject.SetActive(false);
        }
    }

    public void TurnOff()
    {
        dialogBox.SetActive(false);
        Time.timeScale = 1;
    }
}
