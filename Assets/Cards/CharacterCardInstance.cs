using UnityEngine;
using System.Collections.Generic;
using System.Data.Common;

public class CharacterCardInstance
{
    public string cardName;
    public int cost;
    public bool faceUp;
    public Sprite imageBase;
    public string cardType;
    public int characterId;
    public List<string> typesCharacter;
    public int accuracy;
    public int draw;
    public int combat;
    public int toughness;
    public bool hold;
    public bool holdType;
    public int holdWealth;
    public int holdTrip;
    public int holdCurrent;
    public int damage;
    public string temperment;
    public int alcoholism;
    public int lust;
    public int treachory;
    public bool effectAttached;
    public int effectId;
    public int firearmLevel;
    public int combatWeaponLevel;
    public int notoriety;
    public List<string> affiliations;
    public string color;
    public Sprite resourceIcon1;
    public Sprite resourceIcon2;
    public List<int> theftWealth;
    public List<int> theftPreciousMetals;
    public List<int> theftCattle;
    public List<int> theftInvestment;
    public List<int> theftOther;

    public CharacterCardInstance(CharacterCard characterCard)
    {
        cardName = characterCard.cardName;
        cost = characterCard.cost;
        faceUp = characterCard.faceUp;
        imageBase = characterCard.imageBase;
        cardType = characterCard.cardType;
        characterId = characterCard.characterId;
        typesCharacter = characterCard.typesCharacter;
        accuracy = characterCard.accuracy;
        draw = characterCard.draw;
        combat = characterCard.combat;
        toughness = characterCard.toughness;
        hold = false;
        holdType = false;
        holdWealth = 0;
        holdTrip = 0;
        holdCurrent = 0;
        damage = 0;
        temperment = characterCard.temperment;
        alcoholism = characterCard.alcoholism;
        lust = characterCard.lust;
        treachory = characterCard.treachory;
        effectAttached = false;
        effectId = 0;
        firearmLevel = 0;
        combatWeaponLevel = 0;
        notoriety = 0;
        affiliations = characterCard.affiliations;
        color = characterCard.color;
        resourceIcon1 = characterCard.resourceIcon1;
        resourceIcon2 = characterCard.resourceIcon2;
        theftWealth = characterCard.theftWealth;
        theftPreciousMetals = characterCard.theftPreciousMetals;
        theftCattle = characterCard.theftCattle;
        theftInvestment = characterCard.theftInvestment;
        theftOther = characterCard.theftOther;
    }
}