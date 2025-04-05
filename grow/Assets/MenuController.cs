using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class MenuController : MonoBehaviourPunCallbacks
{
    [SerializeField] private string VersioName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;

    [SerializeField] private TMP_InputField UsernameInput;
    [SerializeField] private TMP_InputField CreateGameInput;
    [SerializeField] private TMP_InputField JoinGameInput;

    [SerializeField] private GameObject StartButton;

    private void Awake(){
        PhotonNetwork.GameVersion = VersioName;
        PhotonNetwork.ConnectUsingSettings();
    }

    private void Start(){
        UsernameMenu.SetActive(true);
    }

    public override void OnConnectedToMaster(){
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected");
    }

    public void ChangeUserNameInput(){
    if(UsernameInput.text.Length >= 3){
        StartButton.SetActive(true);
    }
    else{
        StartButton.SetActive(false);
    }
    }

    public void SetUserName(){
        UsernameMenu.SetActive(false);
        PhotonNetwork.NickName = UsernameInput.text;
    }

    public void JoinGame(){
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 20;
        PhotonNetwork.JoinOrCreateRoom("MainRoom", roomOptions, TypedLobby.Default);
    }

    private void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("main game");
    }

}
