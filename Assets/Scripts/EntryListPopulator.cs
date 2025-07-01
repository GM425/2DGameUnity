using UnityEngine;

public class EntryListPopulator : MonoBehaviour
{
    public CharacterCardLibrary entryLibraryCharacter; // drag your SO here
    public GameObject entryPrefab; // drag the EntryItem prefab here
    public Transform contentParent;
    [SerializeField] public CardPreviewSpawner cardPreviewSpawner;

    void Start()
    {
        PopulateListCharacters();
    }

    void PopulateListCharacters()
    {
        // Debug.Log("Library Count: " + entryLibraryCharacter.characters.Count);
        foreach (var character in entryLibraryCharacter.characters)
        {
            GameObject itemGO = Instantiate(entryPrefab, contentParent);
            var ui = itemGO.GetComponent<EntryItemUI>();
            // ui.previewSpawner = referenceToSpawner;
            if (cardPreviewSpawner == null)
            {
                // Debug.LogWarning("previewSpawner is null when being passed into EntryListPopulator!");
            }
            else
            {
                //    Debug.LogWarning("previewSpawner not null when being passed into EntryListPopulator!");
            }
            ui.previewSpawner = cardPreviewSpawner;
            ui.Setup(character);
        }
    }
}