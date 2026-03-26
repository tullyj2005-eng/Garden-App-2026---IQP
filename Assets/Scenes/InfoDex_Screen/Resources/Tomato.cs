using UnityEngine;
using UnityEngine.UI;
using System;

public class Tomato : MonoBehaviour
{
    void Start()
    {
        Action action = () =>
        {
            Debug.Log("Tomato Pressed!!");
            

        };

        Button button = GetComponent<Button>();

        button.onClick.AddListener(() => {
            PopUpScript popup = UI_Controller.Instance.CreatePopup();

            popup.init(UI_Controller.Instance.MainCanvas,
                "Tomatos are great for making sauces and soups!",
                action
                );
        });
    }

    void Update()
    {

    }
}