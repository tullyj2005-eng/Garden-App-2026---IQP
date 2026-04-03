using UnityEngine;
using UnityEngine.UI;
using TMPro; // This is required for TextMeshPro fields to show up

public class PlantCard : MonoBehaviour
{
    
    [SerializeField] public TextMeshProUGUI nameText;       // Drag your "Name" Text object here
    [SerializeField] public Image plantIcon;               // Drag your "Leaf/Plant" Image here
    [SerializeField] public Slider waterSlider;            // Drag your "Health Bar" Slider here

    [HideInInspector]
    public PlantData myData;

    // This function fills the "blank" card with real data
    public void SetupCard(PlantData data)
    {
        myData = data;

        // Safety check: only update if the slots aren't empty
        if (nameText != null) nameText.text = data.plantName;
        // if (plantIcon != null) plantIcon.sprite = data.plantIcon;
    }
}