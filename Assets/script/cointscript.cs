using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cointscript : MonoBehaviour
{
    void Start()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }
    }
}
