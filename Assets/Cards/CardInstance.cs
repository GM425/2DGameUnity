using UnityEngine;

public abstract class CardInstance
{
    public CharacterCard characterCard;

    public CardInstance(CharacterCard data)
    {
        characterCard = data;
    }
}