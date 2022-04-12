using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip onClick, onHover;

    AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hover()
    {
        audioSource.PlayOneShot(onHover);
    }

    public void Click(){
        audioSource.PlayOneShot(onClick);
    }
}
