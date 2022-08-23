using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScript : MonoBehaviour
{
    public float rotationspped;
    public Transform pos1;
    public Transform pos2;
    private bool turnback;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, rotationspped);
        if (transform.position.x >= pos2.position.x)
        {
            turnback = true;
        }
        if (transform.position.x <= pos1.position.x)
        {
            turnback = false;
        }
        if (turnback == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, pos1.position, speed * Time.deltaTime);
        }
        if (turnback == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, pos2.position, speed * Time.deltaTime);
        }
    }
}
