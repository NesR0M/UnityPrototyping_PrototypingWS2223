using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlightenMe : MonoBehaviour
{
    public Light myLight;
    // Start is called before the first frame update
    void Start()
    {
         myLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter( Collision collision){
       
        GameObject light = GameObject.FindWithTag("Sphere");
     
       if (myLight.enabled == true){
           myLight.enabled = false;
       } else {
           myLight.enabled = true;
       }
    }
}
