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

        descriptionText.text = "Mojito mint (Mentha rotundifolia), Wild mint (Mentha aquatica), Pennyroyal (Mentha pulegium), Chocolate mint (Mentha x piperita f.citrata 'Chocolate'), Spearmint (Mentha Spicata): \r\nPlant description Wild Mint: Wild mint (Mentha aquatica), like almost all mint species, is a perennial plant. It stands out for its intense fragrance and the pinkish-purple flowers it produces in spring and summer. It loves rich, moist soils and sunny locations and needs protection from frosts.\r\nThe intense fragrance of its leaves makes it ideal for infusions and essential oil. It is classified as a traditional medicinal product of herbal origin because of its action against stomach disorders and pains.\r\nPlant description Mojit Mint: Mojito mint (Mentha rotundifolia), like almost all mint species, is a perennial plant. It is one of the most widely distributed mint species, both for cultivation and ornamental use. It loves rich, moist soils and sunny locations, and needs protection from frosts.\r\nBecause of its sweet, fruity taste, it is the most popular choice of mint for cooking, making herbal teas and the well-known drink from which it takes its name. Its leaves can also be used to make refreshing drinks in the summer. \r\nPlant description Chocolate Mint: Chocolate mint (Mentha x piperita f.citrata 'Chocolate'), like almost all mint species, is a perennial plant. It loves rich, moist soils and sunny locations and is one of the most cold tolerant mint species. It stands out mainly because of its taste and aroma, but also because of its distinctive dark leaves.\r\n\r\nThe flavour is deep, with hints of hazelnut and a chocolatey aroma, as the name suggests. It is therefore used mainly in cooking, in desserts and fruit dishes. It is also used in the preparation of beverages. \r\nPlant description Spearmint: Spearmint (Mentha Spicata) is a perennial herb which belongs to the mint family.\r\nIt loves rich, moist soils and sunny locations and is one of the most heat-tolerant mint species, although it does need regular watering. It is a popular plant for patios and balconies, but is also successfully grown in the field.\r\nBecause of its strong, characteristic aroma it is widely used in cooking.Its leaves can be used to make refreshing drinks in summer, and its smell seems to drive away mice.\r\nThe extract and essential oils of spearmint have been shown to have antioxidant, anti-cancer, anti-parasitic, anti-microbial and anti-diabetic properties. \r\nPlant description Pennyroyal: Pennyroyal  (Mentha pulegium) is a perennial herb belonging to the mint family. It stands out, however, because it is creeping, which makes it ideal for ground coverage.  It loves rich, moist soils and sunny locations and needs protection from frosts. It's ideal for growing in the field, and its pinkish white flowers make it a striking choice for potting at the balcony.\r\nThe pennyroyal has been harvested in its wild form since ancient times and is used as a herbal tea. The herbal tea of pennyroyal is traditionally used to treat migraines, gastroesophageal problems and rheumatism.\r\nGeneral Information: The entire mint family consists of perennial posas that are propagated by cuttings. The whole family of mint plants is made up of three species of mint, which are grown in the autumn, after the first rains, or in early spring, after the frosts have passed. Harvesting takes place before flowering, three times: at the end of May, at the end of July and the beginning of August and the last at the end of September.\r\nCare: The mint family prefers rich, moist soil, and positions in sun or semi-shade. It needs more watering during periods of drought and heat, with moderate water requirements throughout the year. Chocolate mint has good cold hardiness, while spearmint is more tolerant of warm temperatures. It is recommended that the soil be amended with nitrogen fertilization in February and after the first harvest for drainage.\r\nDrying - Treatment: Drying requires great care. It requires temperatures below 35C as well as zero to minimal humidity. \r\n";

        howToMintText.text = "How to section";
    }
}