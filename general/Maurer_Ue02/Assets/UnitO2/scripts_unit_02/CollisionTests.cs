using UnityEngine;
using System.Collections;

public class CollisionTests : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        Vector3 position = collision.contacts[0].point; //position of the contact point
        
        string name_of_object = collision.gameObject.name; //accessing the gameobject's name you are colliding with
        Debug.Log(name_of_object);

        string tag_of_object = collision.gameObject.tag; //accessing the gameobject's tag you are colliding with
        Debug.Log(tag_of_object);

        Color color = collision.gameObject.GetComponent<Renderer>().material.color; //acessing the other objects color
        Debug.Log(color);


        //if (collision.gameObject.tag == "obstacle")
        //{
        //    //do something
        //    //Destroy(this.gameObject); //destroying THIS gameobject
            
        //    Destroy(collision.gameObject); //destroying the OTHER gameobject
        //}

    }

}