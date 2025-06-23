using UnityEngine;

public class EntryPopulatorCity : MonoBehaviour
{
    public CityCardLibrary cityCardLibrary; // drag your SO here
    public GameObject entryPrefab; // drag the EntryItem prefab here
    public Transform contentParent;
    [SerializeField] public CityCardPreviewSpawner cityCardPreviewSpawner;

    void Start()
    {
        PopulateListCharacters();
    }

    void PopulateListCharacters()
    {
        foreach (var city in cityCardLibrary.cityCards)
        {
            GameObject itemGO = Instantiate(entryPrefab, contentParent);
            var ui = itemGO.GetComponent<EntryCityItemUI>();
            // ui.cityCardPreviewSpawner = cityCardPreviewSpawner;
            if (cityCardPreviewSpawner == null)
            {
                Debug.LogWarning("previewSpawner is null when being passed into EntryListPopulator!");
            }
            else
            {
                   Debug.LogWarning("previewSpawner not null when being passed into EntryListPopulator!");
            }
            ui.cityCardPreviewSpawner = cityCardPreviewSpawner;
            ui.Setup(city);
        }
    }
}
