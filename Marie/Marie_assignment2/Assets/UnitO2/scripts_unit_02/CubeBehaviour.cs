using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    //space for variables
    public string myName; //making these variables public also makes them accesible via other scripts
    public GameObject go;

    public float speed; 

    
    void Start()
    {
        Debug.Log(myName + " is here!");

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * speed);



        if (go != null) // only execute when public gameobject go is not null
        {
            //referencing other gameobject properties
            string name_of_other_cube = go.GetComponent<CubeBehaviour>().myName;
            float speed_of_other_cube = go.GetComponent<CubeBehaviour>().speed;

            Debug.Log(name_of_other_cube + " is also here!" + " It's speed is: " + speed_of_other_cube);
    }
        else
        {
            Debug.Log("game object reference missing!");
        }


    }

    
    void Update()
    {


    }
}

