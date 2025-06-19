using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class CardDisplayCity : MonoBehaviour
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

    public Image typeAccentIcon1;
    public Image typeAccentIcon2;
    public Image typeAccentIcon3;
    public Image typeAccentIcon4;
    public TextMeshProUGUI businessType;
    public TextMeshProUGUI investmentCost;
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

        investmentCost = transform.Find("investmentCost").GetComponent<TextMeshProUGUI>();
        investmentCost.text = cityCard.investmentCost.ToString();

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
    //     public Image typeAccentIcon1;
    // public Image typeAccentIcon2;
    // public Image typeAccentIcon3;
    // public Image typeAccentIcon4;
    // public TextMeshProUGUI businessType;
    // public TextMeshProUGUI investmentCost;
    // public TextMeshProUGUI lossLevels;
    }
}
