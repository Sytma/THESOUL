using System.Collections.Generic;
using UnityEngine;

public class AUDIOMANAGEUR : MonoBehaviour
{
    public static AUDIOMANAGEUR instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
