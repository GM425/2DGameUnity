using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(menuName = "Cards/CardLibrary")]
public class CardLibraryCharacter : ScriptableObject
{
    public List<CharacterCardData> entries;
}