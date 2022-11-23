using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartMe : MonoBehaviour
{
    public float speed;
    public GameObject mySphere;
    private bool alreadyClicked = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((GetComponent<Rigidbody>() != null) && GetComponent<Rigidbody>().IsSleeping())
        {
            GetComponent<Rigidbody>().WakeUp();
        }

        /*
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        */

        if (Input.GetKeyUp(KeyCode.W) && !alreadyClicked)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);

            alreadyClicked = true;
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "dead")
        {
            GameObject newBall = Instantiate(mySphere, new Vector3(3, -1, -6), Quaternion.identity);
            //newBall.GetComponent<Rigidbody>().useGravity = false;

            Destroy(gameObject);
        }
    }
}
