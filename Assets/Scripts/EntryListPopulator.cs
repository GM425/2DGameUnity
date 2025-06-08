using UnityEngine;

public class EntryListPopulator : MonoBehaviour
{
    public CharacterCardLibrary entryLibraryCharacter; // drag your SO here
    public GameObject entryPrefab; // drag the EntryItem prefab here
    public Transform contentParent; // drag the ScrollView/Viewport/Content object here


    void Start()
    {
        PopulateListCharacters();
    }

    void PopulateListCharacters()
    {
        Debug.Log("Library Count: " + entryLibraryCharacter.characters.Count);
        foreach (var character in entryLibraryCharacter.characters)
        {
            GameObject itemGO = Instantiate(entryPrefab, contentParent);
            var ui = itemGO.GetComponent<EntryItemUI>();
            ui.Setup(character, this);
        }
    }
}