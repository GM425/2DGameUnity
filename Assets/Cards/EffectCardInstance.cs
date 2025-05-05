using UnityEngine;
using System.Collections.Generic;

public class EffectCardInstance : CardInstance
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
        public EffectCardInstance(EffectCardData data) : base(data){
            cardType = data.cardType;
            effectType = data.effectType;
            effectId = data.effectId;
            conditionsPlay = data.conditionsPlay;
            conditionsTriggers = data.conditionsTriggers;
            triggersContinuous = data.triggersContinuous;
            triggerSuccess = data.triggerSuccess;
            successEffect = data.successEffect;
            characterAttached = data.characterAttached;
            characterAttachedId = data.characterAttachedId;
        }
}
