// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;

// namespace CardSystem
// {
//     public class CardListItem : MonoBehaviour
//     {
//         [Header("UI Elements")]
//         public TextMeshProUGUI cardNameText;
//         public TextMeshProUGUI cardTypeText;
//         public Image cardIcon;
        
//         private Card card;
//         private CardLibraryViewer libraryViewer;
        
//         public void Initialize(Card card, CardLibraryViewer viewer)
//         {
//             this.card = card;
//             this.libraryViewer = viewer;
            
//             if (cardNameText != null)
//                 cardNameText.text = card.cardName;
                
//             if (cardTypeText != null)
//                 cardTypeText.text = card.cardType.ToString();
                
//             if (cardIcon != null && card.cardImage != null)
//                 cardIcon.sprite = card.cardImage;
                
//             // Add click listener
//             Button button = GetComponent<Button>();
//             if (button != null)
//             {
//                 button.onClick.RemoveAllListeners();
//                 button.onClick.AddListener(OnCardSelected);
//             }
//         }
        
//         public void OnCardSelected()
//         {
//             if (libraryViewer != null)
//             {
//                 libraryViewer.DisplayCardDetails(card);
//             }
//         }
//     }
// }
