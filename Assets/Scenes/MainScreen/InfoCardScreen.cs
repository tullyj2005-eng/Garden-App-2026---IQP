using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoCardScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void ToInfoCardScreen()
    {
        SceneManager.LoadScene("Second_Screen");    
    }

    public void ToRoadMapScreen()
    {
        SceneManager.LoadScene("RoadMapScreen");    
    }
}

