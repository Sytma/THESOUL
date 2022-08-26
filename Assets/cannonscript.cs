using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonscript : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    float timebetween;
    public float starttimebetwen;
    private bool col;
    // Start is called before the first frame update
    void Start()
    {
        timebetween = starttimebetwen;
    }

    // Update is called once per frame
    void Update()
    {
        if(timebetween <= 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            timebetween = starttimebetwen;
        }
        else
        {
            timebetween -= Time.deltaTime;
        }
    }

    
    
       
}
