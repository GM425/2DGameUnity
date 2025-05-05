using UnityEngine;

public abstract class CardInstance
{
    public CardData cardData;

    public CardInstance(CardData data)
    {
        cardData = data;
    }
}