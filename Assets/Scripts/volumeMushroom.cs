using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeMushroom : MonoBehaviour {

    public AudioMixer mushroom;

    public void volume(float volume)
    {
        mushroom.SetFloat("volume", volume);
    }
}
