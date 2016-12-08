using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using FMOD;
using FMODUnity;

public class EventControl : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string eventName;
    public string parameterName;

    private FMOD.Studio.EventInstance eventInstance;
    private FMOD.Studio.ParameterInstance paramInstance;

    public Slider slider;
    public Button startButton;
    public Button stopButton;

    float test;

    void Start()
    {
        slider = GetComponentInChildren<Slider>();
        eventInstance = FMODUnity.RuntimeManager.CreateInstance(eventName);
        eventInstance.getParameter(parameterName, out paramInstance);

        Button startBtn = startButton.GetComponent<Button>();
        Button stopBtn = stopButton.GetComponent<Button>();
        startBtn.onClick.AddListener(SoundOnClick);
        stopBtn.onClick.AddListener(StopOnClick);
    }

    void Update()
    {
        paramInstance.setValue(slider.value);

        UnityEngine.Debug.Log("Slider value: " + slider.value);
    }

    void SoundOnClick()
    {
        eventInstance.start();
    }

    void StopOnClick()
    {
        eventInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}
