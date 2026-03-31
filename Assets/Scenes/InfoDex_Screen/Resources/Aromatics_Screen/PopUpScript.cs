using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class PopUpScript : MonoBehaviour
{
    [SerializeField] Button _button1;
    [SerializeField] Button _button2;
    [SerializeField] Button _button3;
    
    [SerializeField] Text _popupText;
    [SerializeField] Text _titleText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void init(Transform canvas, string contentText, Action action1)
    {
        _popupText.text = contentText;

        transform.SetParent(canvas);
        transform.localScale = Vector3.one;
        transform.localPosition = Vector3.zero;

        _button1.onClick.AddListener(() =>//this is the exit button, leaves the popup
        {
           
            GameObject.Destroy(this.gameObject);
        });

        _button2.onClick.AddListener(() => //this is the track button
        {
            
            action1(); //this action will place the plant into your tracked plants scroll view on the main screen
            GameObject.Destroy(this.gameObject);
        });
    }

}
