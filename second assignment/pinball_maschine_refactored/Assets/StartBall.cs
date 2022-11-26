using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{
    private bool started = false;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        started = false;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetAxis("Booster") == 1)
        {
            Booster();
        }
        */

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Booster();
        }

    }



    void Booster()
    {
        if (!started)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);

            started = true;
        }
    }
}
