using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Podium : MonoBehaviour
{
    public GameObject myPrefab;
    private GameObject activePrefab;
    public bool playerInTrigger = false;
    public float trust;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTrigger)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                activePrefab.GetComponent<Rigidbody>().useGravity = true;
                activePrefab.GetComponent<Rigidbody>().AddForce(transform.up * trust);
                //StartCoroutine(DestroyPrototype());

                //if thing hits ground
                //activePrefab.GetComponent<PROTOTYPE_X_SCRIPT>.onTriggerEnter
            }
        }

        try
        {
            if (activePrefab.GetComponent<PROTOTYPE_X_SCRIPT>().isGrounded)
            {
                GetComponent<AudioSource>().Play();
                activePrefab.GetComponent<PROTOTYPE_X_SCRIPT>().DestroyMe();
            }
        }
        catch {}
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInTrigger = true;
            activePrefab = Instantiate(myPrefab, new Vector3(-42.9788513f, 2.16199994f, -32.0499992f), Quaternion.identity);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerInTrigger = false;
    }

    /*
    IEnumerator DestroyPrototype()
    {
        yield return new WaitForSeconds(0);
        //Spiel Audio ab 
        activePrefab.GetComponent<PROTOTYPE_X_SCRIPT>().DestroyMe();
    }
    */
}
