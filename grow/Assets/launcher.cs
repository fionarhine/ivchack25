using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
    public GameObject GameCanvas; // Assign in Inspector

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // Connects to Photon Cloud
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinRandomRoom(); // Try joining a room
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(null, new RoomOptions()); // Create room if none available
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("✔️ Joined Room!");
        GameCanvas.SetActive(true); // Enable the Spawn Player button
    }
}
