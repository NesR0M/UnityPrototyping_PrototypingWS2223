using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public string nickname;
    private string privateNickname;

    public GameObject go;

    public float speed; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello HCI!!" + "my name is "+ nickname);


        string name_of_other_object = go.GetComponent<CubeController>().nickname;
        float speed_of_other_object = go.GetComponent<CubeController>().speed;

        Debug.Log("other object is called: " + name_of_other_object + "it's as fast as " + speed);


        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * speed);

    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
}
