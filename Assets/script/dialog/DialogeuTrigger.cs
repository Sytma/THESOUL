using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogeuTrigger : MonoBehaviour
{

    public Dialogue dialogeu;

    public void TriggerDialogeur()
    {
        FindObjectOfType<DialogueManageur>().startDialogue(dialogeu);
    }
}
