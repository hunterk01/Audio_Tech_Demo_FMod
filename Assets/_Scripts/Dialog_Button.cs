using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using FMODUnity;

public class Dialog_Button : MonoBehaviour
{
    public Button button;
    public string eventName;

	void Start ()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(SoundOnClick);
	}
	
    void SoundOnClick()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/" + eventName);
    }
}
