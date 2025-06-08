using UnityEngine;
using Unity.Netcode;
using System.Collections.Generic;

public enum GameState
{
    WaitingForPlayers,
    GameStarted,
    Player1Turn,
    Player2Turn,
    GameOver
}

public class GameManager : NetworkBehaviour
{
    public static GameManager Instance;

    public Dictionary<ulong, NetworkList<int>> playerDecks = new Dictionary<ulong, NetworkList<int>>();


    public NetworkVariable<GameState> CurrentGameState = new NetworkVariable<GameState>(GameState.WaitingForPlayers);
    public NetworkList<CharacterCardData> allCharacterCardsChosen = new NetworkList<CharacterCardData>();


    private void Awake()
    {
        Instance = this;
    }

    public override void OnNetworkSpawn()
    {
        if (IsServer)
        {
            NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
        }
    }

    private void OnClientConnected(ulong clientId)
    {
        if (IsServer && NetworkManager.Singleton.ConnectedClients.Count == 2)
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        Debug.Log("Both players connected. Starting game...");
        Debug.Log(CurrentGameState);
        CurrentGameState.Value = GameState.GameStarted;
        SetNextTurn();
    }

    public void SetPlayerDeck(ulong clientId, NetworkList<int> deck)
    {
        playerDecks[clientId] = deck;
    }

    public bool AreBothDecksReady()
    {
        return playerDecks.Count >= 2;
    }

    private void SetNextTurn()
    {
        // Example: alternate between players
        CurrentGameState.Value = GameState.Player1Turn; // Change logic as needed
    }

    public void EndTurn()
    {
        if (!IsServer) return;

        if (CurrentGameState.Value == GameState.Player1Turn)
            CurrentGameState.Value = GameState.Player2Turn;
        else if (CurrentGameState.Value == GameState.Player2Turn)
            CurrentGameState.Value = GameState.Player1Turn;
    }

    public void EndGame()
    {
        if (IsServer)
        {
            CurrentGameState.Value = GameState.GameOver;
        }
    }
}