using UnityEngine;

public class EntryListPopulator : MonoBehaviour
{
    public CharacterCardLibrary entryLibraryCharacter; // drag your SO here
    public EffectCardLibrary entryLibraryEffect; // drag your SO here

    public ItemCardLibrary entryLibraryItem; // drag your SO here

    public GameObject entryPrefab; // drag the EntryItem prefab here
    public Transform contentParent; // drag the ScrollView/Viewport/Content object here

    void Start()
    {
        PlayerState setupData = GetComponent<PlayerState>();
        if (setupData.libraryType == LibraryType.Character){
            PopulateListCharacters();
        } else if (setupData.libraryType == LibraryType.Effect){
            PopulateListEffects();

        } else if (setupData.libraryType == LibraryType.Item){
            PopulateListItems();

        } else {
            PopulateListCharacters();
        }
    }

    void PopulateListCharacters()
    {
        foreach (var character in entryLibraryCharacter.characters)
        {
            GameObject itemGO = Instantiate(entryPrefab, contentParent);
            // var itemUI = itemGO.GetComponent<EntryItemUI>();
            // itemUI.Setup(entry);
        }
    }

       void PopulateListEffects()
    {
        foreach (var effect in entryLibraryEffect.effects)
        {
            GameObject itemGO = Instantiate(entryPrefab, contentParent);
            // var itemUI = itemGO.GetComponent<EntryItemUI>();
            // itemUI.Setup(entry);
        }
    }

       void PopulateListItems()
    {
        foreach (var item in entryLibraryItem.items)
        {
            GameObject itemGO = Instantiate(entryPrefab, contentParent);
            // var itemUI = itemGO.GetComponent<EntryItemUI>();
            // itemUI.Setup(entry);
        }
    }
}