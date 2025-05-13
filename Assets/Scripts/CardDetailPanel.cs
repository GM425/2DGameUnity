// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;

// namespace CardSystem
// {
//     public class CardDetailPanel : MonoBehaviour
//     {
//         [Header("Card Details UI")]
//         public TextMeshProUGUI cardNameText;
//         public TextMeshProUGUI cardTypeText;
//         public TextMeshProUGUI cardDescriptionText;
//         public TextMeshProUGUI cardStatsText;
//         public Image cardImage;
        
//         public void DisplayCard(Card card)
//         {
//             if (card == null)
//             {
//                 Debug.LogWarning("Trying to display a null card");
//                 return;
//             }
            
//             // Set card name
//             if (cardNameText != null)
//                 cardNameText.text = card.cardName;
                
//             // Set type
//             if (cardTypeText != null)
//                 cardTypeText.text = card.cardType.ToString();
                
//             // Set description
//             if (cardDescriptionText != null)
//                 cardDescriptionText.text = card.description;
                
//             // Set stats (customize this based on your Card class structure)
//             if (cardStatsText != null)
//             {
//                 string stats = "";
                
//                 // Add properties based on card type
//                 switch (card.cardType)
//                 {
//                     case CardType.Attack:
//                         stats += $"Damage: {card.damage}\n";
//                         stats += $"Cost: {card.cost}\n";
//                         break;
//                     case CardType.Defense:
//                         stats += $"Block: {card.block}\n";
//                         stats += $"Cost: {card.cost}\n";
//                         break;
//                     case CardType.Skill:
//                         stats += $"Effect: {card.effectDescription}\n";
//                         stats += $"Cost: {card.cost}\n";
//                         break;
//                     default:
//                         stats += $"Cost: {card.cost}\n";
//                         break;
//                 }
                
//                 cardStatsText.text = stats;
//             }
            
//             // Set image
//             if (cardImage != null && card.cardImage != null)
//                 cardImage.sprite = card.cardImage;
                
//             // Show the panel if it was hidden
//             gameObject.SetActive(true);
//         }
//     }
// }
