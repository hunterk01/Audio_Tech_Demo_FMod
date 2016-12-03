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

    public Button button;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(SoundOnClick);

        eventInst = FMODUnity.RuntimeManager.CreateInstance(eventName);
    }

    void SoundOnClick()
    {
        eventInst.start();
    }
}
