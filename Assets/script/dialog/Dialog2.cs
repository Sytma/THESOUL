using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog2 : MonoBehaviour
{
    public TextMeshProUGUI TextDisplay;
    public string sentences;
    private int index;
    public float typingSpeed;

    void Start()
    {
        index = 0;
        StartCoroutine(Type());
    }


    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            TextDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
