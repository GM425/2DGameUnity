using Unity.Collections;
using System.Collections.Generic;
using System.Linq;

public static class CharacterCardExtensions
{
    public static CharacterCardData ToNetworkData(this CharacterCard card)
    {
        return new CharacterCardData
        {
            characterId = card.characterId,
            cardName = card.cardName,
            cost = card.cost,
            accuracy = card.accuracy,
            draw = card.draw,
            combat = card.combat,
            toughness = card.toughness,
            temperment = card.temperment,
            alcoholism = card.alcoholism,
            lust = card.lust,
            treachory = card.treachory,
            color = card.color,

            typesCharacter = JoinList(card.typesCharacter),
            affiliations = JoinList(card.affiliations),

            theftWealth = JoinList(card.theftWealth),
            theftCattle = JoinList(card.theftCattle),
            theftPreciousMetals = JoinList(card.theftPreciousMetals),
            theftInvestment = JoinList(card.theftInvestment),
            theftOther = JoinList(card.theftOther)
        };
    }

      private static FixedString512Bytes JoinList(List<string> list)
    {
        if (list == null || list.Count == 0)
            return new FixedString512Bytes();

        string combined = string.Join(";", list);
        return new FixedString512Bytes(combined);
    }

     private static FixedString512Bytes JoinList(List<int> list)
    {
        if (list == null || list.Count == 0)
            return new FixedString512Bytes();

        string combined = string.Join(",", list.Select(i => i.ToString()));
        return new FixedString512Bytes(combined);
    }
}
