using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnValue;


    // Update is called once per frame
    void Update()
    {
        if((GetComponent<Rigidbody>()!= null) && GetComponent<Rigidbody>().IsSleeping())
        {
            GetComponent<Rigidbody>().WakeUp();
        }

        if(ball.transform.position.y < -spawnValue){
            RespawnPoint();
        }
    }

    void OnTriggerEnter(Collider dataFromCollision){
        if(dataFromCollision.gameObject.name == "void"){
            RespawnPoint();
        }
        Debug.Log("hit detected");
        
    }
    void RespawnPoint(){
        transform.position = spawnPoint.position;
    }

}
