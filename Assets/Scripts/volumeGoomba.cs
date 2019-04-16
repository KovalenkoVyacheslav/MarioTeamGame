using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeGoomba : MonoBehaviour {

    public AudioMixer goomba;
    //public AudioMixerGroup goomba;

    public void volume(float volume)
    {
        goomba.SetFloat("volume", volume);
    }
}
