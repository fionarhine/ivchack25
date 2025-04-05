using UnityEngine;
using UnityEngine.SceneManagement;
public class back : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync("Main menu");
    }

    public void chatLoad(){
        SceneManager.LoadSceneAsync("chatting area");
    }

    public void resourceLoad(){
        SceneManager.LoadSceneAsync("Resource comments");
    }

    public void studyLoad(){
        SceneManager.LoadSceneAsync("study area");
    }


    public void calendar(){
        SceneManager.LoadSceneAsync("calendar");
    }
}
