using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialog2 : MonoBehaviour
{
    public Animator transition;
    public TextMeshProUGUI textCompnent;
    public string[] lines;
    private int index;
    public float textSpeed;
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
        if (cindex < lines[index].Length)
        {
            print(lines[index]);
            char c = lines[index].ToString()[cindex];
            cindex++;
            textCompnent.text += c;
            yield return new WaitForSeconds(textSpeed);

            StartCoroutine("TypeLine");
            Debug.Log(c);
        }

        


    }
    void NextLine()
    {
        if (index < lines.Length-1)
        {
            textCompnent.text = string.Empty;
            cindex = 0;
            index++;
            StartCoroutine("TypeLine");
        }
        else 
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

