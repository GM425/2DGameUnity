using UnityEngine;
using System.Collections.Generic;
public class CardPreviewSpawner : MonoBehaviour
{
    public GameObject characterPreviewPrefab;

    public Transform canvasParent; // set to your Canvas Transform

    public PlayerState playerState;
    public CardPreviewSpawner previewSpawner;

    

    public void ShowPreview(CharacterCard characterCard)
    {
        // GameObject instance = Instantiate(characterPreviewPrefab, canvasParent);
        // var preview = instance.GetComponent<CardDisplayUI>();
        // preview.playerState = playerState; // or pass in card data
        Debug.Log("Preview ran ");
        foreach (Transform child in canvasParent)
        {
            GameObject.Destroy(child.gameObject);
        }

        GameObject preview = Instantiate(characterPreviewPrefab, canvasParent);
        CardDisplayUI ui = preview.GetComponent<CardDisplayUI>();
        RectTransform rect = preview.GetComponent<RectTransform>();
        rect.anchoredPosition = Vector2.zero;
        rect.localScale = Vector3.one;
        rect.offsetMin = Vector2.zero;
        rect.offsetMax = Vector2.zero;

        // var ui = preview.GetComponent<CardDisplayUI>();
        // ui.previewSpawner = this; // Assign this before calling Setup
        ui.Setup(characterCard);
    }
}