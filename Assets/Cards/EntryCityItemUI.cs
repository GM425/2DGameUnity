using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEditor.ShaderGraph;

public class EntryCityItemUI : MonoBehaviour
{
    public TextMeshProUGUI cardNameText;

    public Button viewButton;
    public CityCard cityCard;
    // private EntryListPopulator populator;
    [SerializeField] public CityCardPreviewSpawner cityCardPreviewSpawner;
    public Image namePanel;
    public TextMeshProUGUI nameCard;
    // public CardPreviewSpawner cardPreviewSpawner;
    // [SerializeField] public CardPreviewSpawner referenceToSpawner;
    private void Awake()
    {
        // if (cityCardPreviewSpawner == null)
        // {
            cityCardPreviewSpawner = FindFirstObjectByType<CityCardPreviewSpawner>();
        // }
    }

    public void Setup(CityCard data)
    {
        cityCard = data;
        // referenceToSpawner = GetComponentInChildren<Image>();
        namePanel = GetComponentInChildren<Image>();
        nameCard = GetComponentInChildren<TextMeshProUGUI>();


        Debug.Log("City Name: " + data.name);


        if (cityCard is CityCard baseData)
        {
            Debug.Log("If Statement ran for -" + cityCard.cardName);

            nameCard.text = cityCard.cardName;
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


        }


        viewButton.onClick.AddListener(() =>
        {
            Debug.Log("listener added //////////////////////////////" + cityCard);

            if (cityCardPreviewSpawner == null)
            {
                Debug.LogWarning("previewSpawner is null!");
                return;
            }
            else
            {
                Debug.LogWarning("this is previewSpawner" + cityCardPreviewSpawner);

            }

            cityCardPreviewSpawner.ShowPreview(cityCard);
        });
    }
}