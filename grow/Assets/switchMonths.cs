using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchMonths : MonoBehaviour
{
    public void SwitchToMarch()
    {
        SceneManager.LoadSceneAsync("March");
    }

    public void SwitchToApril()
    {
        SceneManager.LoadSceneAsync("April");
    }

    public void SwitchToMay()
    {
        SceneManager.LoadSceneAsync("May");
    }

    public void SwitchToJune()
    {
        SceneManager.LoadSceneAsync("June");
    }
}
