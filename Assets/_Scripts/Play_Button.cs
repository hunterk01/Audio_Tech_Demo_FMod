using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using FMOD;
using FMODUnity;

public class Play_Button : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string eventName;

    FMOD.Studio.EventInstance eventInst;

    public Button startButton;
    public Button stopButton;

    void Start()
    {
        Button startBtn = startButton.GetComponent<Button>();
        Button stopBtn = startButton.GetComponent<Button>();
        startBtn.onClick.AddListener(SoundOnClick);
        stopBtn.onClick.AddListener(StopOnClick);

        eventInst = FMODUnity.RuntimeManager.CreateInstance(eventName);
    }

    void SoundOnClick()
    {
        eventInst.start();
    }

    void StopOnClick()
    {
        eventInst.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}
