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
    [SerializeField] public TextMeshProUGUI nameText;
    [SerializeField] private Image cardArtImage;

    public Image namePanel;
    public Image statsPanel;
    public Image backgroundPanel;

    public TextMeshProUGUI nameCard;
    public TextMeshProUGUI cost;

    public Image characterImage;

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
    public TextMeshProUGUI affiliations;

    private CharacterCard character;
    // private Action<CharacterCard> onClickHandler;

    public void Setup(CharacterCard characterCard)
    {
        character = characterCard;
        Debug.Log("Setup function to conditional render prefab ran for -" + characterCard.cardName);
        namePanel = GetComponentInChildren<Image>();

        // // THESE LINES are what actually show the card data on screen
        // namePanel = GetComponentInChildren<Image>();
        // nameCard = GetComponentInChildren<TextMeshProUGUI>();
        nameText.text = characterCard.cardName;
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
        // cardArtImage.sprite = characterCard.imageBase;

        // // Optional: set up click behavior
        // GetComponent<Button>().onClick.RemoveAllListeners();
        // GetComponent<Button>().onClick.AddListener(() => {
        //     onClickHandler?.Invoke(currentData);
        // });
    }
}
