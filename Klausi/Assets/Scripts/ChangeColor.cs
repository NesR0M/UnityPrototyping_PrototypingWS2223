using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    bool isWait = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isWait)
        {
            isWait = true;
            StartCoroutine(ColorChanger());
        }

    }

    IEnumerator ColorChanger()
    {
        Color randomColor = new Color(Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1F));
        gameObject.GetComponent<Renderer>().material.color = randomColor;
        yield return new WaitForSeconds(10);
        isWait = false;
    }
}
