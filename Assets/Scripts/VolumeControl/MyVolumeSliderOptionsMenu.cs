using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MyVolumeSliderOptionsMenu : MonoBehaviour
{
    public float volume;
    public AudioMixer mixer;
    public float volumeValue;
    public Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }

    private void Update()
    {
        mixer.SetFloat("Volume", volumeValue);
        PlayerPrefs.SetFloat("Volume", volumeValue);
    }
    public void SetVolume(float volume)
    {
        volumeValue = volume;
    }

    public void LowGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void MediumGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void HighGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(2);
    }

}
