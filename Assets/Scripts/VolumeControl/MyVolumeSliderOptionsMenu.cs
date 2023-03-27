using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MyVolumeSliderOptionsMenu : MonoBehaviour
{
    public float volume;
    public AudioMixer mixer;
public void SetVolume(float volume)
    {
        mixer.SetFloat("Volume", volume);
    }
}
