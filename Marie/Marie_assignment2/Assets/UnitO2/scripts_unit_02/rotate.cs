﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float xAngle, yAngle, zAngle;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);

    }
}
