using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public void OnButtonStage()
    {
        SceneManager.LoadScene("TestScene");
        Time.timeScale = 1f;
    }

    public void OnButtonQuit()
    {
        Application.Quit();
    }
    public void OnButtonTitle()
    {
        SceneManager.LoadScene("StartScene");
    }
}
