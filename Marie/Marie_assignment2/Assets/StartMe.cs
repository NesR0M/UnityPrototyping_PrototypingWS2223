using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMe : MonoBehaviour
{
    public float speed; 
    public GameObject mySphere;
    // Start is called before the first frame update
    void Start()
    { 
         
        
    }

    // Update is called once per frame
    void Update()
    {
        if((GetComponent<Rigidbody>()!= null) && GetComponent<Rigidbody>().IsSleeping()) {
            GetComponent<Rigidbody>().WakeUp();
        }

     
        
        if(Input.GetKey(KeyCode.Space)){

        this.GetComponent<Rigidbody>().useGravity = true;
      
        }

       
        
    }

      void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "dead"){
            Destroy (gameObject);
            Instantiate (mySphere, new Vector3 (0,2,6), Quaternion.identity);
        }
    }
}
