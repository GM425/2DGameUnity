using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Cards/ItemCard")]

public class ItemCard : ScriptableObject
{
    public string cardName;
    public int cost;
    public bool faceUp;
    public Sprite imageBase;
    public string cardType;
    public string accuracyModifier;
    public int accuracyModifierAmount;
    public string drawModifier;
    public int drawModifierAmount;
    public string combatModifier;
    public int combatModifierAmount;
    public string toughnessModifier;
    public int toughnessModifierAmount;
}
