using UnityEngine;

public class PlayAmina : MonoBehaviour
{
    private bool enterGame = true;
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
        if (enterGame)
        {
            GetComponent<Animation>().Play("input");
            enterGame = false;
        }
        
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
    
    public void Hand()
        {
            GetComponent<Animation>().Play("hand");
        }
    
    public void FromHand()
    {
        GetComponent<Animation>().Play("fromHand");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
