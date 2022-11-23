using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinball_movement : MonoBehaviour
{
    public float speed;
    public GameObject targetPosHelper;

    private bool shouldMove = false; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //listen to keyboard input of 'a'
        {
            shouldMove = true;    
        }

        if(shouldMove) 
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);//add force to cube

        if (transform.position.z >= targetPosHelper.transform.position.z) //if movement too far (i.e., target position...stop moving
        {
           transform.position = targetPosHelper.transform.position;
        }
    }
}
