using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

// public class CardDisplayUI : MonoBehaviour
// {
//     public TextMeshProUGUI nameText;
//     public Image artworkImage;
//     public Button actionButton;

//     private CardData cardData;

//     public void Setup(CardData data)
//     {
//         cardData = data;
//         nameText.text = data.cardName;
//         artworkImage.sprite = data.imageBase;

//         actionButton.onClick.RemoveAllListeners();
//         actionButton.onClick.AddListener(() => onClickAction?.Invoke(cardData));
//     }

//     internal void Setup(CardData cardData, bool v)
//     {
//         throw new NotImplementedException();
//     }
// }

public class CardDisplayUI : MonoBehaviour
{
    public Image characterImage;
    [SerializeField] private Sprite redCharacterStatsBackground;
    [SerializeField] private Sprite blueCharacterStatsBackground;
    [SerializeField] private Sprite orangeCharacterStatsBackground;
    [SerializeField] private Sprite yellowCharacterStatsBackground;
    [SerializeField] private Sprite greenCharacterStatsBackground;
    [SerializeField] private Sprite purpleCharacterStatsBackground;
    [SerializeField] public TextMeshProUGUI nameText;
    [SerializeField] private Image cardArtImage;

    public Image namePanel;
    public Image statsPanel;
    public Image backgroundPanel;

    public TextMeshProUGUI nameCard;
    public TextMeshProUGUI cost;


    public Image typeAccentIcon1;
    public Image typeAccentIcon2;

    public TextMeshProUGUI type;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI skillDetails1;
    public TextMeshProUGUI skillDetails2;
    public TextMeshProUGUI accuracy;
    public TextMeshProUGUI combat;
    public TextMeshProUGUI temperment;
    public TextMeshProUGUI alcoholism;
    public TextMeshProUGUI deception;
    public TextMeshProUGUI lust;
    public TextMeshProUGUI substanceAbuse;
    public TextMeshProUGUI affiliations;


    private CharacterCard character;
    // private Action<CharacterCard> onClickHandler;

    public void Setup(CharacterCard characterCard)
    {
        character = characterCard;
        Debug.Log("Setup function to conditional render prefab ran for -" + characterCard.cardName);
        characterImage = transform.Find("characterImage").GetComponent<Image>(); ;
        characterImage.sprite = characterCard.imageBase;
        statsPanel = transform.Find("statsPanel").GetComponent<Image>(); ;
        if (characterCard.color == "Red")
        {
            statsPanel.sprite = redCharacterStatsBackground;
        }
        else if (characterCard.color == "Blue")
        {
            statsPanel.sprite = blueCharacterStatsBackground;
        }
        else if (characterCard.color == "Yellow")
        {
            statsPanel.sprite = yellowCharacterStatsBackground;
        }
        else if (characterCard.color == "Orange")
        {
            statsPanel.sprite = orangeCharacterStatsBackground;
        }
        else if (characterCard.color == "Purple")
        {
            statsPanel.sprite = purpleCharacterStatsBackground;
        }
        else if (characterCard.color == "Green")
        {
            statsPanel.sprite = greenCharacterStatsBackground;
        }
        else if (characterCard.color == "Red")
        {
            statsPanel.sprite = redCharacterStatsBackground;
        }
        else
        {
            statsPanel.sprite = blueCharacterStatsBackground;
        }

        cost = transform.Find("backgroundPanel/cost").GetComponent<TextMeshProUGUI>();
        cost.text = characterCard.cost.ToString();

        accuracy = transform.Find("statsPanel/accuracy").GetComponent<TextMeshProUGUI>();
        accuracy.text = characterCard.draw.ToString() + "/" + characterCard.accuracy.ToString();

        combat = transform.Find("statsPanel/combat").GetComponent<TextMeshProUGUI>();
        combat.text = characterCard.combat.ToString() + "/" + characterCard.toughness.ToString();

        temperment = transform.Find("statsPanel/temperment").GetComponent<TextMeshProUGUI>();
        temperment.text = characterCard.temperment;

        alcoholism = transform.Find("statsPanel/alcoholism").GetComponent<TextMeshProUGUI>();
        alcoholism.text = characterCard.alcoholism.ToString();

        deception = transform.Find("statsPanel/deception").GetComponent<TextMeshProUGUI>();
        deception.text = characterCard.treachory.ToString();

        lust = transform.Find("statsPanel/lust").GetComponent<TextMeshProUGUI>();
        lust.text = characterCard.lust.ToString();

        substanceAbuse = transform.Find("statsPanel/substanceAbuse").GetComponent<TextMeshProUGUI>();
        substanceAbuse.text = characterCard.substanceAbuse.ToString();

        // // THESE LINES are what actually show the card data on screen
        // namePanel = GetComponentInChildren<Image>();
        nameText = transform.Find("backgroundPanel/nameCard").GetComponent<TextMeshProUGUI>();
        nameText.text = characterCard.cardName;

        namePanel = transform.Find("backgroundPanel").GetComponentInChildren<Image>();
        if (characterCard.color == "Red")
        {
            namePanel.color = new Color32(128, 0, 0, 255);
        }
        else if (characterCard.color == "Blue")
        {
            namePanel.color = new Color32(0, 0, 204, 255);

        }
        else if (characterCard.color == "Green")
        {
            namePanel.color = new Color32(0, 102, 34, 255);

        }
        else if (characterCard.color == "Orange")
        {
            namePanel.color = new Color32(204, 104, 0, 255);

        }
        else
        {
            namePanel.color = new Color32(150, 150, 150, 255);

        }

        type = transform.Find("statsPanel/type").GetComponent<TextMeshProUGUI>();
        int typeListLength = characterCard.typesCharacter.Count;
        if (typeListLength == 2)
        {
            type.text = characterCard.typesCharacter[0] + "/" + characterCard.typesCharacter[1];
        }
        else if (typeListLength == 1)
        {
            type.text = characterCard.typesCharacter[0];
        }
        else
        {

        }

        affiliations = transform.Find("statsPanel/affiliations").GetComponent<TextMeshProUGUI>();
        int affiliationsListLength = characterCard.affiliations.Count;
        if (affiliationsListLength == 2)
        {
            affiliations.text = characterCard.affiliations[0] + "/" + characterCard.affiliations[1];
        }
        else if (affiliationsListLength == 1)
        {
            affiliations.text = characterCard.affiliations[0];
        }
        else
        {

        }
        // type.text = characterCard.treachory.ToString();

        // cardArtImage.sprite = characterCard.imageBase;

        // // Optional: set up click behavior
        // GetComponent<Button>().onClick.RemoveAllListeners();
        // GetComponent<Button>().onClick.AddListener(() => {
        //     onClickHandler?.Invoke(currentData);
        // });
    }
}
