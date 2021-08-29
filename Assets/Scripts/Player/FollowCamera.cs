﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target = null;  

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position;
    }
}
