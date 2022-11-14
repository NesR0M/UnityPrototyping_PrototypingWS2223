using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float movementSpeed;
    public float xAxis;
    public float zAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //eulerAngles range between 0 - 360°
        xAxis = (float) transform.eulerAngles.x;
        zAxis = (float) transform.eulerAngles.z;
        

        //rotation on x-axis
        if ((xAxis >= 340f || xAxis <= 25f) && Input.GetKey(KeyCode.W)){
                transform.Rotate(-movementSpeed, 0, 0);
        }
        if ((xAxis >= 335f || xAxis <= 20f) && Input.GetKey(KeyCode.S)){
                transform.Rotate(movementSpeed, 0, 0);
        }


        //rotation on z-axis
        if ((zAxis >= 335f || zAxis <= 25f) && Input.GetKey(KeyCode.A)){
                transform.Rotate(0, 0, -movementSpeed);
        }
        if ((zAxis >= 330f || zAxis <= 20f) && Input.GetKey(KeyCode.D)){
                transform.Rotate(0, 0, movementSpeed);
        }
    }
}