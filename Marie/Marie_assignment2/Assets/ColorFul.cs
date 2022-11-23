using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFul : MonoBehaviour
{
    public GameObject go;
    public Color myColor;
    // Start is called before the first frame update
    void Start()
    {

        go.GetComponent<Renderer>().material.color = myColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision collision)
    {
        Color color = collision.gameObject.GetComponent<Renderer>().material.color;
        myColor = collision.gameObject.GetComponent<Renderer>().material.color; 
        this.gameObject.GetComponent<Renderer>().material.color = myColor;

        
       }
}
