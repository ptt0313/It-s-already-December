using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text life;
    public GameObject MenuPanel;
    private int lifeCount;

    public void StopGame()
    {

  
        bool CheckInt = int.TryParse(life.text, out lifeCount);

        Debug.Log(lifeCount);
        if (CheckInt && lifeCount > 0)
        {
      
            if (Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
                MenuPanel.SetActive(false);
            }
            else
            {
                Time.timeScale = 0f;
                MenuPanel.SetActive(true);
            }

        }
    }

    public void BuildTime()
    {
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
        else if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }
    }
    public void CloseMenuPanel()
    {
        Time.timeScale = 1f;
        MenuPanel.SetActive(false);
    }

}