using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Respawn : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] float spawnValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -spawnValue)
        {
            SpawnANewBall();
            Destroy(gameObject);
            //DoARespawn();
        }

    }

    void SpawnANewBall()
    {
        GameObject[] respawn = GameObject.FindGameObjectsWithTag("Respawn");
        Instantiate(prefab, respawn[0].transform.position, Quaternion.identity);
    }

    void DoARespawn()
    {
        GameObject[] respawn = GameObject.FindGameObjectsWithTag("Respawn");
        transform.position = respawn[0].transform.position;
    }
}
