using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeRegulator : MonoBehaviour {

    public AudioMixer mixer;
    //public AudioClip cl;

    public void setMainVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
    }

    public void setGoombaVolume(float volume)
    {
        mixer.SetFloat("goomba", volume);
    }

    public void setMushroomVolume(float volume)
    {
        mixer.SetFloat("mushroom", volume);
    }
}
