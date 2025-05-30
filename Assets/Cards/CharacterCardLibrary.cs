using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(menuName = "Cards/CharacterCardLibrary")]
public class CharacterCardLibrary : ScriptableObject
{
    public List<CharacterCard> characters;
}