using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonstart : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level1";
    // Start is called before the first frame update
    public void newGameButton()
    {
        SceneManager.LoadScene(newGameLevel);

    }
}
