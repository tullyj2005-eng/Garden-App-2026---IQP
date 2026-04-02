using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackButton : MonoBehaviour
{
    [Header("Settings")]
    public PlantData plantToTrack; // Drag "Lavender" or "Peppermint" here
    public UserGarden masterGarden; // Drag your "MyActiveGarden" asset here
    public string nextSceneName = "MainScene"; // The name of your tracker scene

    public void AddToTracking()
    {
        if (plantToTrack != null && masterGarden != null)
        {
            masterGarden.AddPlant(plantToTrack);
            Debug.Log(plantToTrack.plantName + " added to your garden!");

            // Optional: Switch to the main scene immediately
            // SceneManager.LoadScene(nextSceneName);
        }
    }
}