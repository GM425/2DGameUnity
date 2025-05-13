// using UnityEngine;
// using System.Collections.Generic;

// namespace CardSystem
// {
//     [CreateAssetMenu(fileName = "CardLibrary", menuName = "Card System/Card Library")]
//     public class CardLibrary : ScriptableObject
//     {
//         public List<Card> cards = new List<Card>();
        
//         // Helper methods
//         public Card GetCardByName(string cardName)
//         {
//             return cards.Find(card => card.cardName == cardName);
//         }
        
//         public List<Card> GetCardsByType(CardType type)
//         {
//             return cards.FindAll(card => card.cardType == type);
//         }
//     }
// }
