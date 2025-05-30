using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Cards/EffectCard")]

public class EffectCard : ScriptableObject
{
    public string cardName;
    public int cost;
    public bool faceUp;
    public Sprite imageBase;
    public string cardType;
    public string effectType;
    public int effectId;
    public List<string> conditionsPlay;
    public List<string> conditionsTriggers;
    public bool triggersContinuous;
    public List<string> triggerSuccess;
    public List<string> successEffect;
    public bool characterAttached;
    public int characterAttachedId;
    public string description;
}
