﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnCollision : MonoBehaviour
{

   
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("Player"))
        {
            _ = coll.rigidbody.sleepMode;
        }
        
    }
}
