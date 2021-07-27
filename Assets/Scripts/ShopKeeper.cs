using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : MonoBehaviour
{
    public GameObject shopdialogBox;
    public GameObject talkButton;
    public Dialog dialog;

    bool canTalk = false;

    private void Start()
    {
        shopdialogBox.SetActive(false);
        talkButton.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && canTalk == true)
        {
            talkButton.SetActive(false);
            shopdialogBox.SetActive(true);
            Time.timeScale = 0;
            FindObjectOfType<DialogManager>().StartDialog(dialog);
            canTalk = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            canTalk = true;
            talkButton.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            talkButton.SetActive(false);
        }
    }

    public void TurnOff()
    {
        shopdialogBox.SetActive(false);
        Time.timeScale = 1;
    }
}
