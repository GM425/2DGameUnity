using Unity.Netcode;
using Unity.Collections;
using System;
using System.Collections.Generic;


public struct CharacterCardData : INetworkSerializable, IEquatable<CharacterCardData>
{
    public int characterId;
    public FixedString64Bytes cardName;
    public int cost;
    public int accuracy;
    public int draw;
    public int combat;
    public int toughness;
    public FixedString64Bytes temperment;
    public int alcoholism;
    public int lust;
    public int treachory;
    public FixedString64Bytes color;

    // Flattened string lists (delimited by ';')
    public FixedString512Bytes typesCharacter;
    public FixedString512Bytes affiliations;

    // Flattened int lists (delimited by ',')
    public FixedString512Bytes theftWealth;
    public FixedString512Bytes theftCattle;
    public FixedString512Bytes theftPreciousMetals;
    public FixedString512Bytes theftInvestment;
    public FixedString512Bytes theftOther;

    public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
    {
        serializer.SerializeValue(ref characterId);
        serializer.SerializeValue(ref cardName);
        serializer.SerializeValue(ref cost);
        serializer.SerializeValue(ref accuracy);
        serializer.SerializeValue(ref draw);
        serializer.SerializeValue(ref combat);
        serializer.SerializeValue(ref toughness);
        serializer.SerializeValue(ref temperment);
        serializer.SerializeValue(ref alcoholism);
        serializer.SerializeValue(ref lust);
        serializer.SerializeValue(ref treachory);
        serializer.SerializeValue(ref color);

        serializer.SerializeValue(ref typesCharacter);
        serializer.SerializeValue(ref affiliations);

        serializer.SerializeValue(ref theftWealth);
        serializer.SerializeValue(ref theftCattle);
        serializer.SerializeValue(ref theftPreciousMetals);
        serializer.SerializeValue(ref theftInvestment);
        serializer.SerializeValue(ref theftOther);
    }

        public bool Equals(CharacterCardData other)
    {
        return characterId == other.characterId;
        // You could also do a full field comparison, but usually one unique ID is enough.
    }

    public override int GetHashCode()
    {
        return characterId.GetHashCode();
    }
}
