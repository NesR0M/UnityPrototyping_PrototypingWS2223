using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

public class FloorLights : MonoBehaviour
{
    private bool isWait = false;
    public Color color;
    public Color inactiveColor;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (!isWait)
        {
            isWait = true;
            GameObject[] lights = GameObject.FindGameObjectsWithTag("FloorLight");
            StartCoroutine(wait(lights));
        }
    }

    IEnumerator wait(GameObject[] lights)
    {
        Array.Reverse(lights);
        foreach (GameObject light in lights)
        {
            //Debug.Log(light.ToString() + "is active now");
            light.GetComponent<Renderer>().material.color = color;
            light.GetComponent<Light>().color = color;
            yield return new WaitForSeconds(0.5f);
            light.GetComponent<Renderer>().material.color = inactiveColor;
            light.GetComponent<Light>().color = inactiveColor;
        }
        isWait = false;
    }
}



