using UnityEngine;
using System.Collections.Generic;

public class EffectCardInstance
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
    public string description;
        public EffectCardInstance(EffectCard effect){
            cardType = effect.cardType;
            effectType = effect.effectType;
            effectId = effect.effectId;
            conditionsPlay = effect.conditionsPlay;
            conditionsTriggers = effect.conditionsTriggers;
            triggersContinuous = effect.triggersContinuous;
            triggerSuccess = effect.triggerSuccess;
            successEffect = effect.successEffect;
            characterAttached = effect.characterAttached;
            characterAttachedId = effect.characterAttachedId;
            description = effect.description;
        }
}
