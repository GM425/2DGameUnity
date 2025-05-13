using UnityEngine;
using System.Collections.Generic;
using System.Data.Common;

public class CharacterCardInstance : CardInstance
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
    public List<string> powerUps;
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

    public CharacterCardInstance(CharacterCardData data) : base(data)
    {
        cardName = data.cardName;
        cost = data.cost;
        faceUp = data.faceUp;
        imageBase = data.imageBase;
        cardType = data.cardType;
        characterId = data.characterId;
        typesCharacter = data.typesCharacter;
        accuracy = data.accuracy;
        draw = data.draw;
        combat = data.combat;
        toughness = data.toughness;
        powerUps = data.powerUps;
        damage = data.damage;
        temperment = data.temperment;
        alcoholism = data.alcoholism;
        lust = data.lust;
        treachory = data.treachory;
        effectAttached = data.effectAttached;
        effectId = data.effectId;
        firearmLevel = data.firearmLevel;
        combatWeaponLevel = data.combatWeaponLevel;
        notoriety = data.notoriety;
        affiliations = data.affiliations;
        color = data.color;
        resourceIcon1 = data.resourceIcon1;
        resourceIcon2 = data.resourceIcon2;
        theftWealth = data.theftWealth;
        theftPreciousMetals = data.theftPreciousMetals;
        theftCattle = data.theftCattle;
        theftInvestment = data.theftInvestment;
        theftOther = data.theftOther;

    }
}