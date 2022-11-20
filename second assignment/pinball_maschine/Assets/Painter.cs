using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour
{
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        Color randomColor = new Color(Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1F));
        gameObject.GetComponent<Renderer>().material.color = randomColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
