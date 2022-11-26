using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    private Color objectColor;

    // Start is called before the first frame update
    void Start()
    {
        objectColor = new Color(Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1F));
        gameObject.GetComponent<Renderer>().material.color = objectColor;
        gameObject.GetComponent<Light>().color = objectColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Circles")
        {
            Color gameObjectColor = gameObject.GetComponent<Renderer>().material.color;
            collision.gameObject.GetComponent<Renderer>().material.color = gameObjectColor;
        }
        else if (collision.gameObject.tag == "Bouncer")
        {
            Color collisionColor = collision.gameObject.GetComponent<Renderer>().material.color;
            gameObject.GetComponent<Renderer>().material.color = collisionColor;
            gameObject.GetComponent<Light>().color = collisionColor;
        }

    }

}
