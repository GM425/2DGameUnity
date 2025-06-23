using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class CityCardDisplayUI : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI nameText;
    public Image cityCardImage;
    public Image namePanel;
    public Image statsPanel;
    [SerializeField] private Sprite redCharacterStatsBackground;
    [SerializeField] private Sprite blueCharacterStatsBackground;
    [SerializeField] private Sprite orangeCharacterStatsBackground;
    [SerializeField] private Sprite yellowCharacterStatsBackground;
    [SerializeField] private Sprite greenCharacterStatsBackground;
    [SerializeField] private Sprite purpleCharacterStatsBackground;

    public Image territoryResourceIcon1;
    public Image territoryResourceIcon2;
    public Image territoryResourceIcon3;
    public Image territoryResourceIcon4;
    public Image investmentImage;
    public Image profitImage;
    public TextMeshProUGUI profit;
    public TextMeshProUGUI requirements;
    public TextMeshProUGUI businessType;
    public TextMeshProUGUI investment;
    public TextMeshProUGUI lossLevels;
    private CityCard cityCard;

    public void Setup(CityCard cityCardCurrent)
    {
        cityCard = cityCardCurrent;
        // Debug.Log("Setup function to conditional render prefab ran for -" + characterCard.cardName);
        cityCardImage = transform.Find("characterImage").GetComponent<Image>(); ;
        cityCardImage.sprite = cityCard.locationImage;
        statsPanel = transform.Find("statsPanel").GetComponent<Image>(); ;
        if (cityCard.color == "Red")
        {
            statsPanel.sprite = redCharacterStatsBackground;
        }
        else if (cityCard.color == "Blue")
        {
            statsPanel.sprite = blueCharacterStatsBackground;
        }
        else if (cityCard.color == "Yellow")
        {
            statsPanel.sprite = yellowCharacterStatsBackground;
        }
        else if (cityCard.color == "Orange")
        {
            statsPanel.sprite = orangeCharacterStatsBackground;
        }
        else if (cityCard.color == "Purple")
        {
            statsPanel.sprite = purpleCharacterStatsBackground;
        }
        else if (cityCard.color == "Green")
        {
            statsPanel.sprite = greenCharacterStatsBackground;
        }
        else if (cityCard.color == "Red")
        {
            statsPanel.sprite = redCharacterStatsBackground;
        }
        else
        {
            statsPanel.sprite = blueCharacterStatsBackground;
        }

        investmentImage = transform.Find("ScaleWrapper/investmentImage").GetComponent<Image>();
        investment = transform.Find("ScaleWrapper/investmentCost").GetComponent<TextMeshProUGUI>();
        if (cityCard.investmentCost > 0)
        {
            investment.text = cityCard.investmentCost.ToString();
        }
        else
        {
            investmentImage.enabled = false;
            investment.enabled = false;
        }

        profitImage = transform.Find("ScaleWrapper/profitImage").GetComponent<Image>();
        profit = transform.Find("ScaleWrapper/profit").GetComponent<TextMeshProUGUI>();
        if (cityCard.business == true)
        {
            investment.text = cityCard.profitTurn.ToString() + "/" + cityCard.profitSell.ToString();
        }
        else
        {
            profitImage.enabled = false;
            profit.enabled = false;
        }



        // // THESE LINES are what actually show the card data on screen
        // namePanel = GetComponentInChildren<Image>();
        nameText = transform.Find("nameCard").GetComponent<TextMeshProUGUI>();
        nameText.text = cityCard.cardName;

        namePanel = transform.Find("backgroundPanel").GetComponentInChildren<Image>();
        if (cityCard.color == "Red")
        {
            namePanel.color = new Color32(128, 0, 0, 255);
        }
        else if (cityCard.color == "Blue")
        {
            namePanel.color = new Color32(0, 0, 240, 255);

        }
        else if (cityCard.color == "Green")
        {
            namePanel.color = new Color32(0, 102, 34, 255);

        }
        else if (cityCard.color == "Orange")
        {
            namePanel.color = new Color32(204, 104, 0, 255);

        }
        else if (cityCard.color == "Yellow")
        {
            namePanel.color = new Color32(204, 153, 0, 255);
        }
        else if (cityCard.color == "Purple")
        {
            namePanel.color = new Color32(82, 0, 204, 255);

        }
        else
        {
            namePanel.color = new Color32(150, 150, 150, 255);
        }

        // Still Need To Wire These Up ///////////////////////////////////////////
        territoryResourceIcon1 = transform.Find("ScaleWrapper/territoryResourcesImg1").GetComponent<Image>();

        if (cityCard.territoryResourceIcon1 != null)
        {
            territoryResourceIcon1.sprite = cityCard.territoryResourceIcon1;
        }
        else
        {
            territoryResourceIcon1.enabled = false;
        }

        territoryResourceIcon2 = transform.Find("ScaleWrapper/territoryResourcesImg2").GetComponent<Image>();

        if (cityCard.territoryResourceIcon2 != null)
        {
            territoryResourceIcon2.sprite = cityCard.territoryResourceIcon2;
        }
        else
        {
            territoryResourceIcon2.enabled = false;
        }

        territoryResourceIcon3 = transform.Find("ScaleWrapper/territoryResourcesImg3").GetComponent<Image>();

        if (cityCard.territoryResourceIcon2 != null)
        {
            territoryResourceIcon3.sprite = cityCard.territoryResourceIcon3;
        }
        else
        {
            territoryResourceIcon3.enabled = false;
        }

        territoryResourceIcon4 = transform.Find("ScaleWrapper/territoryResourcesImg4").GetComponent<Image>();

        if (cityCard.territoryResourceIcon4 != null)
        {
            territoryResourceIcon4.sprite = cityCard.territoryResourceIcon4;
        }
        else
        {
            territoryResourceIcon4.enabled = false;
        }

        requirements = transform.Find("ScaleWrapper/investmentCost").GetComponent<TextMeshProUGUI>();
        requirements.text = cityCard.requirements;

        businessType = transform.Find("ScaleWrapper/cardType").GetComponent<TextMeshProUGUI>();
        if (cityCard.business == true)
        {
            businessType.text = "Business / " + cityCard.businessType;
        }
        else
        {
            businessType.text = "Territory";
        }

        if (cityCard.business == true)
        {
            lossLevels.text = cityCard.lossLevels[0] + "/" + cityCard.lossLevels[1] + "/" + cityCard.lossLevels[2] + "/" + cityCard.lossLevels[3] + "/" + cityCard.lossLevels[4];
        }
        else
        {
            lossLevels.enabled = false;
        }

        // public TextMeshProUGUI lossLevels;
    }
}
