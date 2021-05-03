using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform target;
    public Vector3 pos;
    public float offset;

    private void Start()
    {
        pos = transform.position;
    }

    private void FixedUpdate()
    {
        pos.y = target.position.y + offset;

        transform.position = pos;
    }

    
}
