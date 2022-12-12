using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infoscreen : MonoBehaviour
{
    public GameObject floorlights;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerMovement_BM>().visitedHCIInfoscreenBefore = true;

            if(floorlights!= null)
            {
                floorlights.SetActive(true);
            }
        }
    }
}
