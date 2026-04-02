using UnityEngine;

[CreateAssetMenu(fileName = "NewPlant", menuName = "Garden/PlantData")]
public class PlantData : ScriptableObject
{
    public string plantName;
    [TextArea(3, 10)]
    public string description;
    public float waterIntervalHours; // How many hours until it needs water
    public GameObject plantModelPrefab; // The 3D model or Sprite for the main scene
}