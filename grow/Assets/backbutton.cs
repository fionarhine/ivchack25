using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    public void goBack(){
        SceneManager.LoadSceneAsync("options menu");
    }
}
