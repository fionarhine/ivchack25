using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string VersioName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;

    [SerializeField] private InputField UsernameInput;
    [SerializeField] private InputField CreateGameInput;
    [SerializeField] private InputField JoinGameInput;

    private void Awake(){
        PhotonNetwork.ConnectUsingSettings(VersioName);
    }

    private void Start(){
        UsernameMenu.SetActive(true);
    }

    private void OnConnectedToMaster(){
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected");
    }
}
