using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    // Card attributes
    public string cardName;
    public string cardDescription;
    public int manaCost;
    public int attack;
    public int health;
    
    // Card UI elements
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI manaText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;
    public Image cardImage;
    
    // Network ID for syncing
    public int networkID;
    
    // Initialize card with data
    public void InitializeCard(string name, string description, int mana, int atk, int hp, Sprite image = null)
    {
        cardName = name;
        cardDescription = description;
        manaCost = mana;
        attack = atk;
        health = hp;
        
        // Update UI elements if they exist
        if (nameText) nameText.text = cardName;
        if (descriptionText) descriptionText.text = cardDescription;
        if (manaText) manaText.text = manaCost.ToString();
        if (attackText) attackText.text = attack.ToString();
        if (healthText) healthText.text = health.ToString();
        if (cardImage && image) cardImage.sprite = image;
    }
    
    // Method to handle when the card is played
    public void PlayCard()
    {
        Debug.Log("Playing card: " + cardName);
        // Implement card playing logic
    }
    
    // Method for card dragging functionality
    public void OnBeginDrag()
    {
        // Logic for beginning card drag
    }
    
    public void OnDrag()
    {
        // Logic during card dragging
    }
    
    public void OnEndDrag()
    {
        // Logic for ending card drag
    }
}
