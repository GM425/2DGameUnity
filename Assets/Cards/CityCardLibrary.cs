using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Cards/CityCardLibrary")]
public class CityCardLibrary : ScriptableObject
{
    public List<CityCard> cityCards;
}
