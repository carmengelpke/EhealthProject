using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        audioSource.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        audioSource.PlayOneShot(audioSource.clip);
    }
}

// when we want to make sure the audio file presented is different than the ones done before,
// we could use something like this (but need to make sure that it's a variable that is 
// maintained throughout the game, even when the object/card is destroyed.

//AudioClip RandomClip()
//{
//    int attempts = 3;
//    AudioClip newClip = audioClipArray[Random.Range(0, audioClipArray.Length)];

//    while (newClip == lastClip && attempts > 0) 
//    {
//        newClip = audioClipArray[Random.Range(0, audioClipArray.Length)];
//        attempts--;
//    }

//    lastClip = newClip;
//    return newClip;
//}
//}