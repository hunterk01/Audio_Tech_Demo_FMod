using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using FMOD;
using FMODUnity;

public class Event_Slider : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string eventName;

    FMOD.Studio.EventInstance eventInst;
    //FMOD.Studio.ParameterInstance paramInst;

    public Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        eventInst = FMODUnity.RuntimeManager.CreateInstance(eventName);
        //paramInst = FMODUnity.RuntimeManager.CreateInstance(parameterName);
    }

    void Update()
    {
        eventInst.setParameterValue("Intensity", slider.value);
    }
}
