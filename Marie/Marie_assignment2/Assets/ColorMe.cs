using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMe : MonoBehaviour
{   
    public Color myColor;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        myColor = new Color (255,0,0);
        go.GetComponent<Renderer>().material.color = myColor;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
       if (collision.gameObject.tag == "boundaries"){
       myColor = new Color(Random.Range(0, 1F), Random.Range(0, 1F), Random.Range(0, 1F)); 
      this.gameObject.GetComponent<Renderer>().material.color = myColor;
       
       }
    }
}
