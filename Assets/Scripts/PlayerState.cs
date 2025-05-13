using UnityEngine;
using System.Collections.Generic;


public class PlayerState
{
    public List<CardInstance> deck = new();
    public List<CardInstance> hand = new();    
    public void AddCard(CardInstance card)
    {
        if (hand.Count <= 4){
            hand.Add(card);
        } 
    }
}