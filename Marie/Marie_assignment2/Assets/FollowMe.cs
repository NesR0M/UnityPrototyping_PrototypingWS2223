using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour
{ 
    public Vector3 translation;
    public Transform sphere;
    // Start is called before the first frame update
    void Start()
    {
    }  

    // Update is called once per frame
    void Update()
    { 

     try
        {
            transform.position = sphere.position + translation;
        }
        catch (Exception)
        {
            GameObject[] newBall = GameObject.FindGameObjectsWithTag("Sphere");
            sphere = newBall[0].transform;
        }   
       
    }
     
}
