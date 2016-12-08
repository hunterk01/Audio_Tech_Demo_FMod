using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using FMOD;
using FMODUnity;

public class Event_Slider : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string eventName;
    public string parameterName;

    FMOD.Studio.EventDescription _event;
    FMOD.Studio.PARAMETER_DESCRIPTION _param;

    public Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        FMODUnity.RuntimeManager.StudioSystem.getEvent(eventName, out _event);
        _event.getParameter(parameterName, out _param);
    }

    void Update()
    {
        //paramInst.setValue(slider.value);
        _param.defaultValue = slider.value;

        UnityEngine.Debug.Log("Slider value: " + slider.value);
    }
}
