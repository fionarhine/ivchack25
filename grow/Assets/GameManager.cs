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

    public void SpawnPlayer(){
        // Correctly assign a random float value
        float randomValue = Random.Range(-1f, 1f);

        // Instantiate the player at a random position
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector2(this.transform.position.x * randomValue, this.transform.position.y), Quaternion.identity, 0);

        GameCanvas.SetActive(false);
        SceneCamera.SetActive(false);
    }
}
