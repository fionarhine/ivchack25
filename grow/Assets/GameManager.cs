using UnityEngine;
using Photon.Pun; // Ensure this is included

public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject GameCanvas;
    public GameObject SceneCamera;

    private void Awake(){
        GameCanvas.SetActive(true);
    }

    public void SpawnPlayer()
    {
        // Check if you're connected and in a room
        if (!PhotonNetwork.IsConnected || !PhotonNetwork.InRoom)
        {
            Debug.LogWarning("You must be connected and in a room to spawn a player!");
            return;
        }

        // Set a specific spawn position
        Vector3 spawnPosition = new Vector3(0, 0, 0);  // Replace with the actual position you want the player to spawn at

        // Optionally, you can add some randomness or a spawn system based on the position
        spawnPosition = new Vector3(this.transform.position.x * Random.Range(-1f, 1f), this.transform.position.y, this.transform.position.z); // Example for random spawn position

        // Instantiate the player at the defined spawn position
        PhotonNetwork.Instantiate(PlayerPrefab.name, spawnPosition, Quaternion.identity);

        GameCanvas.SetActive(false);
        SceneCamera.SetActive(false);
    }
        

}