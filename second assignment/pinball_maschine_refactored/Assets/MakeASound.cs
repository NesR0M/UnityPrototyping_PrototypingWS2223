using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeASound : MonoBehaviour
{
    public AudioClip saw;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play(); //Ballgeraeusch
    }
}


/* Instructor Work: 
 * Add the Audio Clip
 */
