using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Change_Scene : MonoBehaviour
{
    public Button button1;
    public Button button2;

    public void Scene(string sceneName)
    {
        if (button1 != null)
        {
            ExecuteEvents.Execute(button1.gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }

        if (button2 != null)
        {
            ExecuteEvents.Execute(button2.gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }

        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
