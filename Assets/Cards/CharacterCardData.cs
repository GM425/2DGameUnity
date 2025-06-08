using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Cards/CharacterCard")]
public class CharacterCard : ScriptableObject
{
    public string cardName;
    public int cost;
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
    public string temperment;
    public int alcoholism;
    public int lust;
    public int treachory;
    public List<string> affiliations;
    public string color;
    public Sprite resourceIcon1;
    public Sprite resourceIcon2;
    public List<int> theftWealth;
    public List<int> theftPreciousMetals;
    public List<int> theftCattle;
    public List<int> theftInvestment;
    public List<int> theftOther;
}
