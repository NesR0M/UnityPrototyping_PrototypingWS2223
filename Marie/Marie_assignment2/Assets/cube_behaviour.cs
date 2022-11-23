using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_behaviour : MonoBehaviour
{
    public string myName;
    
    public float speed;

    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi my name is " + myName);


        string name_of_other_go = go.GetComponent<cube_behaviour>().myName;
        float speed_of_other_go = go.GetComponent<cube_behaviour>().speed;

        Debug.Log("the other object is called " + name_of_other_go + ". its speed is " + speed_of_other_go.ToString());


        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        

        

    }
}
