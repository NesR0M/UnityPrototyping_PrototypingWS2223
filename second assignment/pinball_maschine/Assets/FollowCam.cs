using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Vector3 myPos;
    public Transform myPlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        try
        {
            transform.position = myPlay.position + myPos;
        }
        catch (Exception e)
        {
            GameObject[] newBall = GameObject.FindGameObjectsWithTag("Ball");
            myPlay = newBall[0].transform;
        }
        
    }
}
