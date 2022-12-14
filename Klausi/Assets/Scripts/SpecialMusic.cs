using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class SpecialMusic : MonoBehaviour
{
    GameObject backgroundsound;
    public float backgroundsound_volume;
    public float backgroundsound_minVolume = 0.05f;
    public float backgroundsound_maxVolume;
    // Start is called before the first frame update
    void Start()
    {
        backgroundsound = GameObject.FindGameObjectWithTag("BackgroundMusic");
        backgroundsound_volume = backgroundsound.GetComponent<AudioSource>().volume;
        backgroundsound_maxVolume = backgroundsound_volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(DecreaseSound());

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(RiseSound());
        }
    }

    IEnumerator DecreaseSound()
    {
        while (backgroundsound_volume > backgroundsound_minVolume)
        {
            yield return null;
                backgroundsound_volume -= Time.deltaTime/2;
                backgroundsound.GetComponent<AudioSource>().volume = backgroundsound_volume;

        }
        yield break;
    }
    IEnumerator RiseSound()
    {
        while (backgroundsound_volume <= backgroundsound_maxVolume)
        {
            yield return null;
                backgroundsound_volume += Time.deltaTime/2;
                backgroundsound.GetComponent<AudioSource>().volume = backgroundsound_volume;
                
        }
        yield break;
    }
}
