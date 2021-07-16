using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundCameraScript: MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        if (viewPos.y >= 3.62f)
        {
            viewPos = new Vector3(transform.position.x, 3.75f, transform.position.z);
            transform.position = viewPos;
        }
        transform.position = viewPos;
    }
}