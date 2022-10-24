using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandom : MonoBehaviour
{
    public AudioSource randomSound;

    public AudioClip[] audioSources;

    // Use this for initialization

    private void Awake()
    {
        randomSound = GetComponent<AudioSource>();

    }
    void Start()
    {
        CallAudio();
    }


    void CallAudio()
    {
        Invoke("RandomSoundness", 5);
    }

    void RandomSoundness()
    {
        randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        randomSound.Play();
        CallAudio();
    }
}
