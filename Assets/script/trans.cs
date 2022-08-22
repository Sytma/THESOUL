using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trans: MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    
    IEnumerator LoadLevel(int levelIndex)
    {
       
        transition.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

        
    }
}
