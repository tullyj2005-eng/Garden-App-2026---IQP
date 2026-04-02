using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserGarden", menuName = "Garden/UserGarden")]
public class UserGarden : ScriptableObject
{
    // This is the list of plants the user is currently tracking
    public List<PlantData> trackedPlants = new List<PlantData>();

    // Helper method to add a plant
    public void AddPlant(PlantData newPlant)
    {
        if (!trackedPlants.Contains(newPlant))
        {
            trackedPlants.Add(newPlant);
        }
    }
}