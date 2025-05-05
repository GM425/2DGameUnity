using UnityEngine;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode.Transports.UTP;

public class NetworkConnectionUI : MonoBehaviour
{
    public Button hostButton;
    public Button clientButton;
    public TMP_InputField ipInputField;
    public TMP_Text statusText;


    private void Start()
    {
        hostButton.onClick.AddListener(StartHost);
        clientButton.onClick.AddListener(StartClient);
         if (NetworkManager.Singleton.IsClient)
        {
            Debug.Log("🟢 Client started");
        }
        NetworkManager.Singleton.OnClientConnectedCallback += (clientId) =>
        {
            Debug.Log("Client connected with ID: " + clientId);
        };
        // Optional: Auto-fill for convenience
        ipInputField.text = "127.0.0.1";
    }

    public void StartHost()
    {
        // Starts host mode (acts as both server and client)
        NetworkManager.Singleton.StartHost();
        Debug.Log("Host started.");
    }

    public void StartClient()
    {
        string ipAddress = ipInputField.text.Trim();
        if (!string.IsNullOrEmpty(ipAddress))
        {
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetConnectionData(ipAddress, 7777);
            NetworkManager.Singleton.StartClient();
            Debug.Log($"Client trying to connect to {ipAddress}:7777");
            statusText.text=$"Client trying to connect to {ipAddress}:7777";
        }
    }
}


