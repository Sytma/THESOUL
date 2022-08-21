using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManageur : MonoBehaviour
{
    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void startDialogue(Dialogue dialogue)
    {
        Debug.Log("starting conversation with" + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentences();
    }
    public void DisplayNextSentences ()
    {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
                   
            }
            string sentence = sentences.Dequeue();
            Debug.Log(sentence);

    }
        void EndDialogue()
        {
            Debug.Log("End of conversation.");
        }
}
