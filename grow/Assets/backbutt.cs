using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutt : MonoBehaviour
{
    public void goBack(){
        SceneManager.LoadSceneAsync("options menu");
    }   
}
