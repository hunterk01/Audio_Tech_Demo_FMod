using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using FMOD;
using FMODUnity;

public class AudioController : MonoBehaviour
{
    public float musicMasterVolume;
    public float sfxMasterVolume;
    public float dialogMasterVolume;

    public Slider musicMasterSlider;
    public Slider sfxMasterSlider;
    public Slider dialogMasterSlider;

    FMOD.SoundGroup musicGroup;

	void Start ()
    {

	}
	
	void Update ()
    {
        SliderVolumeUpdate();
	}

    void SliderVolumeUpdate()
    {
        musicMasterVolume = musicMasterSlider.value;
        sfxMasterVolume = sfxMasterSlider.value;
        dialogMasterVolume = dialogMasterSlider.value;
    }

    void ChangeMasterVolumes()
    {
        // Access FMOD mixer master buses and adjust volume
        FMOD.
    }
}
