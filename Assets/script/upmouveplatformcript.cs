using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upmouveplatformcript : MonoBehaviour
{
    public float speed;
    public Transform pos3;
    public Transform pos4;
    bool turnback;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= pos3.position.y)
        {
            turnback = true;
        }
        if (transform.position.y <= pos4.position.y)
        {
            turnback = false;
        }
        if (turnback)
        {
            transform.position = Vector2.MoveTowards(transform.position, pos4.position, speed * Time.deltaTime);

        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, pos3.position, speed * Time.deltaTime);
        }
    }
}
