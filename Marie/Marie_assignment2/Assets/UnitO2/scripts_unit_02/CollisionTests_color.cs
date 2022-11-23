using UnityEngine;
using System.Collections;

public class CollisionTests_color : MonoBehaviour
{

    public Color color;


    void OnCollisionEnter(Collision collision)
    {

        color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F)); //create a random color

        collision.gameObject.GetComponent<Renderer>().material.color = color; //Set it to the object you collide with

        
    }
}