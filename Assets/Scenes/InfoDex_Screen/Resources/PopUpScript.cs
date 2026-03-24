using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class PopUpScript : MonoBehaviour
{
    [SerializeField] Button _button1;
    [SerializeField] Button _button2;
    [SerializeField] Text _button1Text;
    [SerializeField] Text _button2Text;
    [SerializeField] Text _popupText;

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

        _button1.onClick.AddListener(() =>
        {
            action1();
            GameObject.Destroy(this.gameObject);
        });

        _button2.onClick.AddListener(() =>
        {
             GameObject.Destroy(this.gameObject);
        });
    }

}
