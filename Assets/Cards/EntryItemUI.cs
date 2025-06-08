using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEditor.ShaderGraph;


// public class EntryItemUI : MonoBehaviour
// {
//     // private TextMeshProUGUI nameText;
//     public Image namePanel;
//     public Image statsPanel;
//     public Image backgroundPanel;

//     public TextMeshProUGUI nameCard;
//     public TextMeshProUGUI cost;

//     public Image characterImage;

//     public Image typeAccentIcon1;
//     public Image typeAccentIcon2;

//     public TextMeshProUGUI type;
//     public TextMeshProUGUI descriptionText;
//     public TextMeshProUGUI skillDetails1;
//     public TextMeshProUGUI skillDetails2;
//     public TextMeshProUGUI accuracy;
//     public TextMeshProUGUI combat;
//     public TextMeshProUGUI temperment;
//     public TextMeshProUGUI alcoholism;
//     public TextMeshProUGUI deception;
//     public TextMeshProUGUI lust;
//     public TextMeshProUGUI affiliations;


//     void Awake()
//     {
//         namePanel = GetComponentInChildren<Image>();
//         statsPanel = GetComponentInChildren<Image>();
//         backgroundPanel = GetComponentInChildren<Image>();
//         nameCard = GetComponentInChildren<TextMeshProUGUI>();
//         cost = GetComponentInChildren<TextMeshProUGUI>();
//         characterImage = GetComponentInChildren<Image>();
//         typeAccentIcon1 = GetComponentInChildren<Image>();
//         typeAccentIcon2 = GetComponentInChildren<Image>();
//         type = GetComponentInChildren<TextMeshProUGUI>();
//         skillDetails1 = GetComponentInChildren<TextMeshProUGUI>();
//         skillDetails2 = GetComponentInChildren<TextMeshProUGUI>();
//         accuracy = GetComponentInChildren<TextMeshProUGUI>();
//         combat = GetComponentInChildren<TextMeshProUGUI>();
//         temperment = GetComponentInChildren<TextMeshProUGUI>();
//         alcoholism = GetComponentInChildren<TextMeshProUGUI>();;
//         deception = GetComponentInChildren<TextMeshProUGUI>();;
//         lust = GetComponentInChildren<TextMeshProUGUI>();
//     }


//     public void Setup()
//     PlayerState.libraryType
//     {
//         nameCard.text = data.cardName;
//         cost.text = Convert.ToString(data.cost);
//         if (data.color == "red"){
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);
//         } else if (data.color == "blue"){
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);        
//         }  else if (data.color == "green"){
//              namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);     
//         } else if (data.color == "purple"){
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);     
//         } else if (data.color == "black"){
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);     
//         } else if (data.color == "orange"){
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);     
//         } else if (data.color == "yellow"){
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);     
//         } else if (data.color == "blue"){
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);     
//         } else {
//             namePanel.color = new Color32(128, 64, 255, 255);
//             statsPanel.color = new Color32(128, 64, 255, 255);
//             backgroundPanel.color = new Color32(128, 64, 255, 255);     
//         } 

//         characterImage.sprite = data.imageBase;

//         if (data.typesCharacter[0] == "Th"){
//             typeAccentIcon1.sprite = data.resourceIcon1; 
//             typeAccentIcon2.sprite = data.resourceIcon2;
//             skillDetails1.text = data.theftWealth[0] + "/" + data.theftWealth[1] + "/" + data.theftWealth[2];
//                 if (data.theftPreciousMetals.Count >= 1){
//                     skillDetails1.text = data.theftPreciousMetals[0] + "/" + data.theftPreciousMetals[1] + "/" + data.theftPreciousMetals[2];
//                 } else if (data.theftCattle.Count >= 1){
//                     skillDetails2.text = data.theftCattle[0] + "/" + data.theftCattle[1] + "/" + data.theftCattle[2];
//                 } else if (data.theftInvestment.Count >= 1){
//                     skillDetails2.text = data.theftInvestment[0] + "/" + data.theftInvestment[1] + "/" + data.theftInvestment[2];
//                 } else if (data.theftOther.Count >= 1){
//                     skillDetails2.text = data.theftOther[0] + "/" + data.theftOther[1] + "/" + data.theftOther[2];
//                 } else {

//                 }
//         }

//         if (data.typesCharacter.Count > 1){
//             type.text = data.typesCharacter[0] + "/" + data.typesCharacter[1];
//         } else {
//             type.text = data.typesCharacter[0];
//         }
//         accuracy.text = Convert.ToString(data.draw) + "/" + Convert.ToString(data.accuracy);
//         combat.text = Convert.ToString(data.combat) + "/" + Convert.ToString(data.toughness);

//         temperment.text = data.temperment;
//         alcoholism.text = Convert.ToString(data.alcoholism);
//         deception.text = Convert.ToString(data.treachory);
//         lust.text = Convert.ToString(data.lust);
//                     Debug.Log($"affiliations = {data.affiliations[0]}");
//                     Debug.Log($"affiliations = {data.affiliations[1]}");

//         if (data.affiliations.Count >= 1){

//             if (data.affiliations.Count == 2){
//                 affiliations.text = data.affiliations[0] + "/" + data.affiliations[1];
//             } else {
//                 affiliations.text = data.affiliations[0];
//             }
//         }



//     }

// }

public class EntryItemUI : MonoBehaviour
{
    public TextMeshProUGUI cardNameText;

    public Button viewButton;
    public Button addButton;

    private CharacterCard cardData;
    private EntryListPopulator populator;
    public Image namePanel;
    public TextMeshProUGUI nameCard;

    public void Setup(CharacterCard data, EntryListPopulator populatorRef)
    {
        cardData = data;
        populator = populatorRef;
        namePanel = GetComponentInChildren<Image>();
        nameCard = GetComponentInChildren<TextMeshProUGUI>();
            Debug.Log("Character Name: " + data.name);


        if (cardData is CharacterCard baseData)
        {
            Debug.Log("If Statement ran for -" + baseData.cardName);

            nameCard.text = baseData.cardName;
            if (baseData.color == "Red") {
                namePanel.color = new Color32(128, 0, 0, 255);
            } else if (baseData.color == "Blue") {
                namePanel.color = new Color32(0, 0, 204, 255);

            } else if (baseData.color == "Green") {
                namePanel.color = new Color32(0, 102, 34, 255);

            } else if (baseData.color == "Orange") {
                namePanel.color = new Color32(204, 104, 0, 255);

            } else {
                namePanel.color = new Color32(150, 150, 150, 255);

            }

        }

        // previewButton.onClick.AddListener(() => populator.ShowPreview(cardData));
        // addToDeckButton.onClick.AddListener(() => populator.AddToDeck(cardData));
    }
}