using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip saw;
    public GameObject prefab;
    private Color objectColor;

    [SerializeField] float spawnValue;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;

        objectColor = new Color(Random.Range(0F, 1F), Random.Range(0F, 1F), Random.Range(0F, 1F));
        gameObject.GetComponent<Renderer>().material.color = objectColor;
        gameObject.GetComponent<Light>().color = objectColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -spawnValue)
        {
            //Debug.Log("Time to DIE!!");
            SpawnANewBall();
            Destroy(gameObject);
            //Respawn();
        }

        if (Input.GetAxis("Booster") == 1)
        {
            Booster();
        }


    }

    void OnCollisionEnter(Collision collision) 
    {
        GetComponent<AudioSource>().Play(); //Ballgeräusch


        if (collision.gameObject.tag == "Circles")
        {
            Color gameObjectColor = gameObject.GetComponent<Renderer>().material.color;
            collision.gameObject.GetComponent<Renderer>().material.color = gameObjectColor;
        }
        else if (collision.gameObject.tag == "Bouncer")
        {
            Color collisionColor = collision.gameObject.GetComponent<Renderer>().material.color;
            gameObject.GetComponent<Renderer>().material.color = collisionColor;
            gameObject.GetComponent<Light>().color = collisionColor;
        }

    }

    void SpawnANewBall()
    {
        GameObject[] respawn = GameObject.FindGameObjectsWithTag("Respawn");
        Instantiate(prefab, respawn[0].transform.position, Quaternion.identity);
    }

    void Respawn()
    {
        GameObject[] respawn = GameObject.FindGameObjectsWithTag("Respawn");
        transform.position = respawn[0].transform.position;
    }

    void Booster()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * 2);
    }
}
