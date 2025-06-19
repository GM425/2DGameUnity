using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(menuName = "Cards/CityCard")]

public class CityCard : ScriptableObject
{
    public int locationId;
    public string cardName;
    public Sprite locationImage;
    public Sprite typeAccentIcon1;
    public Sprite typeAccentIcon2;
    public Sprite typeAccentIcon3;
    public Sprite typeAccentIcon4;
    public bool business;
    public string businessType;
    public int maxHerd;
    public int profitTurn;
    public int profitSell;
    public List<int> lossLevels;
    public int investmentCost;
    public string city;
    public string color;
}