using UnityEngine;

public class EntryPopulatorCity : MonoBehaviour
{
    public CityCardLibrary cityCardLibrary; // drag your SO here
    public GameObject entryPrefab; // drag the EntryItem prefab here
    public Transform contentParent;
    // [SerializeField] public CityCardPreviewSpawner cityCardPreviewSpawner;

    // void Awake()
    // {
    //     if (cityCardPreviewSpawner == null)
    //     {
    //         Debug.LogError("CityCardPreviewSpawner is STILL null in Awake! You need to assign it in the Inspector.");
    //     }
    //     else
    //     {
    //             Debug.Log("Active EntryPopulatorCity instance: " + gameObject.name);

    //     }
    // }

    void Start()
    {
        Debug.Log("Active EntryPopulatorCity instance: " + gameObject.name);
        Debug.Log("City library count: " + cityCardLibrary.cityCards.Count);
        PopulateListCityLocations();
    }

    void PopulateListCityLocations()
    {
        foreach (var city in cityCardLibrary.cityCards)
        {
            GameObject itemGO = Instantiate(entryPrefab, contentParent);
            var ui = itemGO.GetComponent<EntryCityItemUI>();
            // ui.cityCardPreviewSpawner = cityCardPreviewSpawner;
            // if (cityCardPreviewSpawner == null)
            // {
            //     Debug.LogWarning("previewSpawner is null when being passed into EntryListPopulator!");
            // }
            // else
            // {
            //        Debug.LogWarning("previewSpawner not null when being passed into EntryListPopulator!");
            // }
            // Debug.LogWarning("line30ran!");
            // ui.cityCardPreviewSpawner = cityCardPreviewSpawner;
            // Debug.LogWarning("line32ran!");
            if (ui == null)
            {
                Debug.LogError("ui (EntryCityItemUI) is null after instantiating entryPrefab!");
            }
            else
            {
                Debug.Log("ui is valid, proceeding with Setup.");
                ui.Setup(city);
            }

            ui.Setup(city);
        }
    }
}
