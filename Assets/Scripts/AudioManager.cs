using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip CountdownMusic;

    public AudioClip StartScene;

    void Start()
    {
        //To help connect the audio source with the components in audio manager
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = CountdownMusic;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //if the intro sound is not being played...switch to StartScene music
        if (!audioSource.isPlaying && audioSource.clip == CountdownMusic)
        {
            //To switch music 
            audioSource.clip = StartScene;
            audioSource.Play();
        }
    }
}
