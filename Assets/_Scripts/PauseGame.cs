using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
    public Transform canvas;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
            
        }
    }

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Cursor.visible = false;
            Time.timeScale = 1;
        }
     }
 }

