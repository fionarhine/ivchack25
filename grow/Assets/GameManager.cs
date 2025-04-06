using UnityEngine;
using Photon.Pun;

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
        Vector3 spawnPosition = new Vector3(0, 0, 0); 
        spawnPosition = new Vector3(this.transform.position.x * Random.Range(-1f, 1f), this.transform.position.y, this.transform.position.z); 
        PhotonNetwork.Instantiate(PlayerPrefab.name, spawnPosition, Quaternion.identity);

        GameCanvas.SetActive(false);
        SceneCamera.SetActive(false);
    }
        

}