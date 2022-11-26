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
        catch (Exception)
        {
            GameObject[] newBall = GameObject.FindGameObjectsWithTag("Player");
            myPlay = newBall[0].transform;
        }
        
    }
}

/* Instructor work:
 * MyPos: -10 10 0 (Normally change the z Axis not the x Axis!)
 * MyPlay: Pinball GameObject
 * Give the Pinball PreFab the Tag "Player"
 */

