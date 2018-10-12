using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip coinSound, sawSound;
    static AudioSource audioSrc;

	void Start () {
        coinSound = Resources.Load<AudioClip>("CoinSound");
        sawSound = Resources.Load<AudioClip>("SawSound");

        audioSrc = GetComponent<AudioSource>();
    }


    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "CoinSound":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "SawSound":
                audioSrc.PlayOneShot(sawSound);
                break;
        }
    }
}
