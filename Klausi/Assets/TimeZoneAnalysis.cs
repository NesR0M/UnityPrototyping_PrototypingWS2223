using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class TimeZoneAnalysis : MonoBehaviour
{
    private float timer;
    private float timertotal;
    private bool isInArea = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInArea)
        {
            timer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isInArea= true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInArea = false;

            timertotal = timertotal + timer;
            print("The Player was spending: " + timer.ToString("F2") + " seconds in " 
                + gameObject.name + ".\n Total time spend in " + gameObject.name + ": "+ timertotal.ToString("F2") + " seconds.");
            timer = 0f;
        }
    }





}
