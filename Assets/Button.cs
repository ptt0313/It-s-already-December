using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public void OnButtonStage()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void OnButtonQuit()
    {
        Application.Quit();
    }
    public void OnButtonTitle()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void  StageResetScene()
    {
        SceneManager.LoadScene("Stage1");
    }
}
