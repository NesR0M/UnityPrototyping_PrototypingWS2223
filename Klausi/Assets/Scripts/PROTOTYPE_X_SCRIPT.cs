using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROTOTYPE_X_SCRIPT : MonoBehaviour
{
    public bool doRotation = false;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (doRotation)
        {
            transform.Rotate(0, 0, 2);
        }
    }


    public void DestroyMe()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            isGrounded = true;
        }
    }

}
