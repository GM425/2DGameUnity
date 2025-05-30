using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(menuName = "Cards/EffectCardLibrary")]
public class EffectCardLibrary : ScriptableObject
{
    public List<EffectCard> effects;
}