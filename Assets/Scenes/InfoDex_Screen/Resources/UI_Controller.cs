using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public static UI_Controller Instance;
    public Transform MainCanvas;


    void Start()
    {
        if (Instance != null)
        {
            // Fixed: "GameObject" was spelled "GameObjeect"
            // Fixed: "gameObject" should be lowercase for the property
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }

    public PopUpScript CreatePopup()
    {
        GameObject popUpGo = Instantiate(Resources.Load("UI/PopUp") as GameObject);

        // Fixed: Use <Popup> (the class name) instead of <popUpGo> (the variable name)
        return popUpGo.GetComponent<PopUpScript>();
    }
}