using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync("options menu");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
