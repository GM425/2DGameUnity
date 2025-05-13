using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;

// namespace CardSystem
// {
//     public class CardLibraryViewer : MonoBehaviour
//     {
//         public CardLibrary cardLibrary;
        
//         [Header("UI References")]
//         public Transform cardListContent;
//         public GameObject cardListItemPrefab;
//         public CardDetailPanel detailPanel;

//         private void Start()
//         {
//             if (cardLibrary == null)
//             {
//                 // Try to find the CardLibrary.asset file
//                 cardLibrary = Resources.Load<CardLibrary>("Cards/CardLibrary");
                
//                 if(cardLibrary == null)
//                 {
//                     Debug.LogError("CardLibrary not assigned and could not be found at Resources/Cards/CardLibrary");
//                     return;
//                 }
//             }
            
//             LoadCardList();
//         }

//         public void LoadCardList()
//         {
//             // Clear existing card items
//             foreach (Transform child in cardListContent)
//             {
//                 Destroy(child.gameObject);
//             }
            
//             if (cardLibrary == null || cardLibrary.cards == null)
//             {
//                 Debug.LogWarning("CardLibrary or its card list is null");
//                 return;
//             }
            
//             // Instantiate a list item for each card
//             foreach (var card in cardLibrary.cards)
//             {
//                 if (card == null) continue;
                
//                 GameObject listItemObj = Instantiate(cardListItemPrefab, cardListContent);
//                 CardListItem listItem = listItemObj.GetComponent<CardListItem>();
                
//                 if (listItem != null)
//                 {
//                     listItem.Initialize(card, this);
//                 }
//             }
//         }
        
//         public void DisplayCardDetails(Card card)
//         {
//             if (detailPanel != null)
//             {
//                 detailPanel.DisplayCard(card);
//             }
//         }
//     }
// }
