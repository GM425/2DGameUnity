// using UnityEngine;
// using UnityEditor;
// using System.Collections.Generic;

// namespace CardSystem.Editor
// {
//     [CustomEditor(typeof(CardLibrary))]
//     public class CardLibraryEditor : UnityEditor.Editor
//     {
//         private bool showCards = true;
//         private Vector2 scrollPosition;
//         private Dictionary<CardType, bool> typeFoldouts = new Dictionary<CardType, bool>();
        
//         public override void OnInspectorGUI()
//         {
//             CardLibrary library = (CardLibrary)target;
            
//             EditorGUILayout.LabelField("Card Library", EditorStyles.boldLabel);
            
//             EditorGUILayout.Space();
            
//             // Standard inspector for basic properties
//             DrawDefaultInspector();
            
//             EditorGUILayout.Space();
            
//             // Custom card viewing section
//             showCards = EditorGUILayout.Foldout(showCards, "View Cards by Type", true);
            
//             if (showCards)
//             {
//                 scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
                
//                 // Initialize foldouts for each card type
//                 foreach (CardType type in System.Enum.GetValues(typeof(CardType)))
//                 {
//                     if (!typeFoldouts.ContainsKey(type))
//                     {
//                         typeFoldouts.Add(type, false);
//                     }
//                 }
                
//                 // Display cards by type
//                 foreach (CardType type in System.Enum.GetValues(typeof(CardType)))
//                 {
//                     List<Card> cardsOfType = library.GetCardsByType(type);
                    
//                     // Only show types with cards
//                     if (cardsOfType.Count > 0)
//                     {
//                         typeFoldouts[type] = EditorGUILayout.Foldout(typeFoldouts[type], $"{type} Cards ({cardsOfType.Count})", true);
                        
//                         if (typeFoldouts[type])
//                         {
//                             EditorGUI.indentLevel++;
                            
//                             foreach (Card card in cardsOfType)
//                             {
//                                 EditorGUILayout.BeginHorizontal();
                                
//                                 // Show card icon if available
//                                 if (card.cardImage != null)
//                                 {
//                                     GUILayout.Box(card.cardImage.texture, GUILayout.Width(40), GUILayout.Height(40));
//                                 }
//                                 else
//                                 {
//                                     GUILayout.Box("No Image", GUILayout.Width(40), GUILayout.Height(40));
//                                 }
                                
//                                 EditorGUILayout.BeginVertical();
//                                 EditorGUILayout.LabelField(card.cardName, EditorStyles.boldLabel);
//                                 EditorGUILayout.LabelField($"Cost: {card.cost}");
//                                 EditorGUILayout.LabelField(card.description, EditorStyles.wordWrappedLabel);
//                                 EditorGUILayout.EndVertical();
                                
//                                 if (GUILayout.Button("Edit", GUILayout.Width(60)))
//                                 {
//                                     Selection.activeObject = card;
//                                 }
                                
//                                 EditorGUILayout.EndHorizontal();
                                
//                                 EditorGUILayout.Space();
//                             }
                            
//                             EditorGUI.indentLevel--;
//                         }
//                     }
//                 }
                
//                 EditorGUILayout.EndScrollView();
//             }
            
//             EditorGUILayout.Space();
            
//             // Add card button
//             if (GUILayout.Button("Create New Card"))
//             {
//                 CreateNewCard(library);
//             }
//         }
        
//         private void CreateNewCard(CardLibrary library)
//         {
//             // Create a new card asset
//             Card newCard = ScriptableObject.CreateInstance<Card>();
//             newCard.cardName = "New Card";
            
//             // Create a save file dialog
//             string path = EditorUtility.SaveFilePanelInProject(
//                 "Create New Card",
//                 "New Card",
//                 "asset",
//                 "Create a new card asset"
//             );
            
//             // If the user pressed cancel, do nothing
//             if (string.IsNullOrEmpty(path))
//                 return;
                
//             // Create the asset
//             AssetDatabase.CreateAsset(newCard, path);
//             AssetDatabase.SaveAssets();
            
//             // Add the card to the library
//             library.cards.Add(newCard);
//             EditorUtility.SetDirty(library);
//             AssetDatabase.SaveAssets();
            
//             // Select the new card
//             Selection.activeObject = newCard;
//         }
//     }
// }
