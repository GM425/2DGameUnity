using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEditor.ShaderGraph;

public class EntryItemUI : MonoBehaviour
{
    public TextMeshProUGUI cardNameText;

    public Button viewButton;
    public Button addButton;

    public CharacterCard characterCard;
    // private EntryListPopulator populator;
    [SerializeField] public CardPreviewSpawner previewSpawner;
    public Image namePanel;
    public TextMeshProUGUI nameCard;
    // public CardPreviewSpawner cardPreviewSpawner;
    // [SerializeField] public CardPreviewSpawner referenceToSpawner;

    public void Setup(CharacterCard data)
    {
        characterCard = data;
        // referenceToSpawner = GetComponentInChildren<Image>();
        namePanel = GetComponentInChildren<Image>();
        nameCard = GetComponentInChildren<TextMeshProUGUI>();


        Debug.Log("Character Name: " + data.name);


        if (characterCard is CharacterCard baseData)
        {
            Debug.Log("If Statement ran for -" + characterCard.cardName);

            nameCard.text = characterCard.cardName;
            if (characterCard.color == "Red")
            {
                namePanel.color = new Color32(128, 0, 0, 255);
            }
            else if (characterCard.color == "Blue")
            {
                namePanel.color = new Color32(0, 0, 240, 255);

            }
            else if (characterCard.color == "Green")
            {
                namePanel.color = new Color32(0, 102, 34, 255);

            }
            else if (characterCard.color == "Orange")
            {
                namePanel.color = new Color32(204, 104, 0, 255);

            }
            else if (characterCard.color == "Yellow")
            {
                namePanel.color = new Color32(204, 153, 0, 255);

            }
            else if (characterCard.color == "Purple")
            {
                namePanel.color = new Color32(82, 0, 204, 255);

            }
              else if (characterCard.color == "Black")
            {
                namePanel.color = new Color32(0, 0, 0, 255);

            }
            else if (characterCard.color == "GoldBlue")
            {
                namePanel.color = new Color32(204, 153, 0, 255);
            }
            else
            {
                namePanel.color = new Color32(150, 150, 150, 255);

            }
           

        }


        viewButton.onClick.AddListener(() =>
        {
            Debug.Log("listener added //////////////////////////////" + characterCard);

            if (previewSpawner == null)
            {
                Debug.LogWarning("previewSpawner is null!");
                return;
            }
            else
            {
                Debug.LogWarning("this is previewSpawner" + previewSpawner);

            }

            previewSpawner.ShowPreview(characterCard);
        });
        // addButton.onClick.AddListener(() => populator.AddToDeck(cardData));
    }
}