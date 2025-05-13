using UnityEngine;

public class EntryListPopulator : MonoBehaviour
{
    // public CardLibrary entryLibrary; // drag your SO here
    public GameObject entryPrefab; // drag the EntryItem prefab here
    public Transform contentParent; // drag the ScrollView/Viewport/Content object here

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
    //     foreach (var entry in entryLibrary.entries)
    //     {
    //         GameObject itemGO = Instantiate(entryPrefab, contentParent);
    //         var itemUI = itemGO.GetComponent<EntryItemUI>();
    //         itemUI.Setup(entry);
    //     }
    }
}