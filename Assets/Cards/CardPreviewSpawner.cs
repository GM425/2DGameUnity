using UnityEngine;
using System.Collections.Generic;
public class CardPreviewSpawner : MonoBehaviour
{
    public GameObject characterPreviewPrefab;
    public GameObject effectPreviewPrefab;
    public GameObject itemPreviewPrefab;

    public Transform canvasParent; // set to your Canvas Transform

    public PlayerState playerState;

    public void ShowPreview()
    {
        GameObject prefabToUse = null;

        switch (playerState.libraryType)
        {
            case LibraryType.Character:
                prefabToUse = characterPreviewPrefab;
                break;
            case LibraryType.Effect:
                prefabToUse = effectPreviewPrefab;
                break;
            case LibraryType.Item:
                prefabToUse = itemPreviewPrefab;
                break;
            default:
                Debug.LogWarning("Unknown library type: " + playerState.libraryType);
                return;
        }

        GameObject instance = Instantiate(prefabToUse, canvasParent);
        // CardPreviewUI preview = instance.GetComponent<CardPreviewUI>();
        // preview.playerState = playerState; // or pass in card data
    }
}