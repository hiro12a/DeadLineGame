using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogText;
    Cutscene cut;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>(); 
        cut = FindObjectOfType<Cutscene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if (sentences.Count == 0)
            {
                EndDialog();
            }

            string sentence = sentences.Dequeue();
            dialogText.text = sentence;
        }
    }

    public void StartDialog(Dialog dialog)
    {
        sentences.Clear();

        foreach(string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
   
    }

    public void EndDialog()
    {
        cut.TurnOff();
    }
}
