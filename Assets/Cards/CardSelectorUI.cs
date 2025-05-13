using UnityEngine;

public class CardSelectorUI : MonoBehaviour
{
    public Transform cardListParent;
    public GameObject cardItemPrefab;
    public CardLibraryCharacter cardLibraryCharacter;
    // public CardLibraryCharacter cardLibraryEffects;

    // public CardLibraryCharacter cardLibraryItems;

    public PlayerState playerState;

    private void Start()
    {
        PopulateCardList();
    }

    void PopulateCardList()
    {
        foreach (Transform child in cardListParent)
            Destroy(child.gameObject);

        //werite if statement and populate depending on variable in local state

        foreach (CardData card in cardLibraryCharacter.entries)
        {
            GameObject cardGO = Instantiate(cardItemPrefab, cardListParent);
            CardDisplayUI display = cardGO.GetComponent<CardDisplayUI>();
            display.Setup(card, OnAddCardToDeck);
        }
    }

    void OnAddCardToDeck(CardData data)
    {
        // playerState.AddCard(data);
        Debug.Log($"Added {data.cardName} to deck.");
    }
}
