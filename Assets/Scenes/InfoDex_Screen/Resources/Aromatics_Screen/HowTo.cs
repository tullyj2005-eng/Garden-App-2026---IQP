using UnityEngine;

public class HowTo : MonoBehaviour
{
    /*
     * This script toggles between the How To menu and the Description menu.
     */

    [Header("Menu References")]
    public GameObject HowToMenu;
    public GameObject DescriptionMenu;

    public void OpenHowTo()
    {
        // Activate HowTo, Deactivate Description
        HowToMenu.SetActive(true);
        DescriptionMenu.SetActive(false);
    }

    public void OpenDescription()
    {
        // Deactivate HowTo, Activate Description
        HowToMenu.SetActive(false);
        DescriptionMenu.SetActive(true);
    }
}