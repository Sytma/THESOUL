using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    //public Transform soultransform;
    // Vector3 range;
    private Vector3 offset = new Vector3(0f, 3f, -10f);
    private float smoothtime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform target;
    void Awake()
    {
        //range = transform.position - soultransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset ;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothtime );
       // transform.position = new Vector3(range.x + soultransform.position.x, soultransform.position.y, range.z + soultransform.position.z);
    }
}
