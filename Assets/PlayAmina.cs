using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAmina : MonoBehaviour
{

    public void StartPressed()
    {
        GetComponent<Animation>().Play("start");
    }

    public void SettingsPressed()
    {
        GetComponent<Animation>().Play("settings");
    }

    public void BackPressed()
    {
        GetComponent<Animation>().Play("back");
    }

    public void InputPressed()
    {
        GetComponent<Animation>().Play("input");
    }

    public void BackToMenuPressed()
    {
        GetComponent<Animation>().Play("backToMenu");
    }
    
    public void Statistic()
    {
        GetComponent<Animation>().Play("statistic");
    }
    
    public void BackToText()
    {
        GetComponent<Animation>().Play("backToText");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
