using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(menuName = "Cards/ItemCardLibrary")]
public class ItemCardLibrary : ScriptableObject
{
    public List<ItemCard> items;
}