using UnityEngine;

public class GardenDisplayManager : MonoBehaviour
{
    public UserGarden masterGarden; // Drag "MyActiveGarden" asset here
    public GameObject plantCardPrefab; // Drag your UI Prefab here
    public Transform contentLocation; // Drag the "Content" object here

    void Start()
    {
        RefreshGarden();
    }

    public void RefreshGarden()
    {
        // Clear existing UI entries first
        foreach (Transform child in contentLocation)
        {
            Destroy(child.gameObject);
        }

        // Create a card for every plant in our list
        foreach (PlantData plant in masterGarden.trackedPlants)
        {
            GameObject newCard = Instantiate(plantCardPrefab, contentLocation);
            // We will link the logic to the card in the next step!
            Debug.Log("Created UI for: " + plant.plantName);
        }
    }
}