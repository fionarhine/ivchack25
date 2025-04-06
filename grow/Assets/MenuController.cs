using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class MenuController : MonoBehaviourPunCallbacks
{
    [SerializeField] private string VersionName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private TMP_InputField UsernameInput;
    [SerializeField] private Button JoinButton;

    [SerializeField] private GameObject StartButton;

    private bool isLobbyReady = false;

    private void Awake()
    {
        PhotonNetwork.GameVersion = VersionName;
        PhotonNetwork.ConnectUsingSettings();
    }

    public void ChangeUserNameInput(){
     if(UsernameInput.text.Length >= 3){
         StartButton.SetActive(true);
     }
     else{
         StartButton.SetActive(false);
     }
     }

    private void Start()
    {
        UsernameMenu.SetActive(true);
        JoinButton.interactable = false;
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(); 
        Debug.Log("Connected to Master Server.");
    }

    public override void OnJoinedLobby()
    {
        isLobbyReady = true;
        Debug.Log("Joined Lobby.");
        JoinButton.interactable = true;
    }

    public void SetUserNameAndJoin()
    {
        if (UsernameInput.text.Length < 3 || !isLobbyReady)
        {
            Debug.LogWarning("Username too short or not connected.");
            return;
        }

        PhotonNetwork.NickName = UsernameInput.text;
        UsernameMenu.SetActive(false);

        RoomOptions roomOptions = new RoomOptions { MaxPlayers = 20 };
        PhotonNetwork.JoinOrCreateRoom("MainRoom", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room successfully. Loading game scene...");
        PhotonNetwork.LoadLevel("main game"); 
    }
}
