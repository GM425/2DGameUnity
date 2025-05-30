using UnityEngine;
using System.Collections.Generic;

public enum LibraryType
{
    Character,
    Effect,
    Item
}

public class PlayerState : MonoBehaviour
{
    public LibraryType libraryType = LibraryType.Character;
    public int previewLibraryId;
    public List<CardInstance> deck = new();
    public List<CardInstance> hand = new();    
    public void AddCard(CardInstance card)
    {
        if (hand.Count <= 4){
            hand.Add(card);
        } 
    }
}