using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog2 : MonoBehaviour
{
    public TextMeshProUGUI textCompnent;
    public string[] lines;
    private int index;
    public float textSpeed;
    private char c;
    private int cindex = 0;

    void Start()
    {
        textCompnent.text = string.Empty;
        StartDialogue();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(textCompnent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textCompnent.text = lines[index];
            }
        }
            
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine("TypeLine");
        
    }

    IEnumerator TypeLine()
    {
       // Debug.Log(lines);

        /*Debug.Log("IEnu..");
        foreach (char c in lines[index].ToString())
        {
            Debug.Log("foreach");
            textCompnent.text += c;
            yield return new WaitForSeconds(textSpeed);*/
        if(cindex < lines.Length)
        {
          //  Debug.Log(lines.Length);
          //  Debug.Log(c);
            c = lines.ToString()[cindex];
            cindex++;
            textCompnent.text += c;

            yield return new WaitForSeconds(textSpeed);

            StartCoroutine("TypeLine");
        }


    }
    void NextLine()
    {
        if (cindex < lines.Length-1)
        {
            cindex++;
            textCompnent.text += string.Empty;
            StartCoroutine("TypeLine");
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

