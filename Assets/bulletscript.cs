using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = transform.right * speed * -1;
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
