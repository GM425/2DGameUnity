using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEditor.ShaderGraph;


public class EntryItemUI : MonoBehaviour
{
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


    public void Setup(CharacterCardData data)
    {
        nameCard.text = data.cardName;
        cost.text = Convert.ToString(data.cost);
        if (data.color == "red"){
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);
        } else if (data.color == "blue"){
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);        
        }  else if (data.color == "green"){
             namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);     
        } else if (data.color == "purple"){
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);     
        } else if (data.color == "black"){
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);     
        } else if (data.color == "orange"){
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);     
        } else if (data.color == "yellow"){
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);     
        } else if (data.color == "blue"){
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);     
        } else {
            namePanel.color = new Color32(128, 64, 255, 255);
            statsPanel.color = new Color32(128, 64, 255, 255);
            backgroundPanel.color = new Color32(128, 64, 255, 255);     
        } 

        characterImage.sprite = data.imageBase;

        if (data.typesCharacter[0] == "Th"){
            typeAccentIcon1.sprite = data.resourceIcon1; 
            typeAccentIcon2.sprite = data.resourceIcon2;
        }


        if (data.typesCharacter.Count > 1){
            type.text = data.typesCharacter[0];
        } else {
            type.text = data.typesCharacter[0] + "/" + data.typesCharacter[1];
        }
        accuracy.text = Convert.ToString(data.draw) + "/" + Convert.ToString(data.accuracy);
        combat.text = Convert.ToString(data.combat) + "/" + Convert.ToString(data.toughness);

        // temperment.text = entry.description;
        // characterImage.sprite = data.imageBase;
    }
}