using UnityEngine;
using UnityEngine.UI; // Required for Button
using TMPro; // Use TextMeshPro for better visual quality

public class MintMenu : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Button mintButton;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private TMP_Text howToMintText;
    [SerializeField] private TMP_Text titleText;

    void Start()
    {
        // Add the listener once when the game starts
        if (mintButton != null)
        {
            mintButton.onClick.AddListener(SetMintText);
        }
    }

    void SetMintText()
    {
        titleText.text = "Mint:";

        descriptionText.text = "Minting is the process of creating a new NFT. When you mint an NFT, " +
                               "you are creating a unique digital asset that can be bought, sold, " +
                               "and traded on the blockchain.";

        howToMintText.text = "To mint an NFT, you will need to follow these steps:\n" +
                             "1. Choose a platform (OpenSea, Rarible, etc.).\n" +
                             "2. Connect your cryptocurrency wallet.\n" +
                             "3. Upload your digital file and metadata.\n" +
                             "4. Set a price or auction style.\n" +
                             "5. Pay the minting fee to finalize.";
    }
}