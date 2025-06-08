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
    public int skillType1;
    public int skillType2;
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
    public bool managing;
    public int managingId;
    public int closeCombat1Level;
    public int closeCombat2Level;
    public int pistolLevel;
    public int rifleLevel;
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
        imageBase = characterCard.imageBase;
        cardType = characterCard.cardType;
        characterId = characterCard.characterId;
        typesCharacter = characterCard.typesCharacter;
        skillType1 = characterCard.skillType1;
        skillType2 = characterCard.skillType2;
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
        managing = false;
        managingId = 0;
        closeCombat1Level = 0;
        closeCombat2Level = 0;
        pistolLevel = 0;
        rifleLevel = 0;
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