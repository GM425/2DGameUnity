using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardDisplayUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public Image artworkImage;
    public Button actionButton;

    private CardData cardData;

    public void Setup(CardData data, System.Action<CardData> onClickAction)
    {
        cardData = data;
        nameText.text = data.cardName;
        artworkImage.sprite = data.imageBase;

        actionButton.onClick.RemoveAllListeners();
        actionButton.onClick.AddListener(() => onClickAction?.Invoke(cardData));
    }
}
