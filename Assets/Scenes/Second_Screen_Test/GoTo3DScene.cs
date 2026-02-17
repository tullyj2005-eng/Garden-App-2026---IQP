using UnityEngine;
using UnityEngine.SceneManagement;


public class GoTo3DScene : MonoBehaviour
{
  public void NextScene()
    {
        SceneManager.LoadScene("3D_Scene");    
    }
}
