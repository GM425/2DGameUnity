using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Cards/EffectCard")]

public class EffectCardData : CardData
{
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
}
