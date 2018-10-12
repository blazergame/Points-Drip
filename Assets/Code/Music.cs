using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public AudioSource myAudio;

    // Use this for initialization
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.mute = false;
    }

    public void ToggleMusic(bool turnOn)
    {
         myAudio.mute = turnOn ? false : true;
    }

}
