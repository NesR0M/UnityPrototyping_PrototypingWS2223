using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGive : MonoBehaviour
{
    public Color myColor;
    public GameObject go;
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
        collision.gameObject.GetComponent<Renderer>().material.color = myColor;
       }
}
