using UnityEngine;

public class MainScreenTracker : MonoBehaviour
{
    public SelectedPlantState stateTracker; // Drag "ActivePlantTracker" here

    void Start()
    {
        if (stateTracker.currentPlant != null)
        {
            Debug.Log("Loading: " + stateTracker.currentPlant.plantName);
            Instantiate(stateTracker.currentPlant.plantModelPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
