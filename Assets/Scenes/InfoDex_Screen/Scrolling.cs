using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scrolling : MonoBehaviour
{
    public Text directionText;
    private Touch theTouch;
    private Vector2 touchStartPos, touchEndPos;
    private string direction;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            if (theTouch.phase == TouchPhase.Began)
            {
                touchStartPos = theTouch.position;
            }
            else if (theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended)
            {
                touchEndPos = theTouch.position;
                float x = touchEndPos.x - touchStartPos.x;
                float y = touchEndPos.y - touchStartPos.y;
                float distance = Vector2.Distance(touchStartPos, touchEndPos); //this should allow me to detect the distance swiped
                if (distance > 50f) { // threshold to avoid detecting small movements as scrolls
                    if (Mathf.Abs(x) > Mathf.Abs(y))
                    {
                        direction = x > 0 ? "Right" : "Left";
                    }
                    else
                    {
                        direction = y > 0 ? "Up" : "Down";
                    }

                }else
                {
                    direction = "No movement";
                }
                    directionText.text = "Direction: " + direction;
            }
        }

        /*
        if((direction == "Right") || (SceneManager.GetActiveScene().name == "Main_Screen"))
        {
            SceneManager.LoadScene("RoadMapScreen");
        }
        else if ((direction == "Right") || (SceneManager.GetActiveScene().name == "InfoScreen"))
        {
            SceneManager.LoadScene("Main_Screen");
        }
        else if ((direction == "Left") || (SceneManager.GetActiveScene().name == "RoadMapScreen"))
        {
            SceneManager.LoadScene("Main_Screen");
        }
        else if ((direction == "Left") || (SceneManager.GetActiveScene().name == "Main_Screen"))
        {
                       SceneManager.LoadScene("InfoScreen");
        }
        */

    }
}
