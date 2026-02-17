using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainScreen : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Main_Screen");    
    }
}
