using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour
{
    public string nextSceneName = "MainScene";
    public float splashScreenDuration = 3f;

    void Start()
    {
        Invoke("LoadNextScene", splashScreenDuration);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
