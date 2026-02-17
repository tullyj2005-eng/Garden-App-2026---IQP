using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_To_Second_Screen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void NextScene()
    {
        SceneManager.LoadScene("Second_Screen");    
    }
}
