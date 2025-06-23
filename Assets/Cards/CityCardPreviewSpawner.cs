using UnityEngine;
using System.Collections.Generic;
public class CityCardPreviewSpawner : MonoBehaviour
{
    public GameObject cityPreviewPrefab;

    public Transform canvasParent; // set to your Canvas Transform

    public PlayerState playerState;

    public CityCardLibrary cityCardLibrary;

    

    public void ShowPreview(CityCard cityCard)
    {
        // GameObject instance = Instantiate(characterPreviewPrefab, canvasParent);
        // var preview = instance.GetComponent<CardDisplayUI>();
        // preview.playerState = playerState; // or pass in card data
        Debug.Log(cityCardLibrary.cityCards);
        foreach (Transform child in canvasParent)
        {
            GameObject.Destroy(child.gameObject);
        }

        GameObject preview = Instantiate(cityPreviewPrefab, canvasParent);
        CityCardDisplayUI ui = preview.GetComponent<CityCardDisplayUI>();
        RectTransform rect = preview.GetComponent<RectTransform>();
        rect.anchoredPosition = Vector2.zero;
        rect.localScale = Vector3.one;
        rect.offsetMin = Vector2.zero;
        rect.offsetMax = Vector2.zero;
        ui.Setup(cityCard);
    }
}