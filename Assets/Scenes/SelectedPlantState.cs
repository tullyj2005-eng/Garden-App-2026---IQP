

using UnityEngine;


[CreateAssetMenu(fileName = "SelectedPlantState", menuName = "LearningApp/State")]
public class SelectedPlantState : ScriptableObject

{
    public PlantData currentPlant; //this holds the reference to the active plant
}
