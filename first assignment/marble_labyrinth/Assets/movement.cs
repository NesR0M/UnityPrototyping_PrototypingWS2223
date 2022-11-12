using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
            transform.Rotate(-movementSpeed, 0,0);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(movementSpeed, 0,0);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, 0, -movementSpeed);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 0, movementSpeed);
    }
}
