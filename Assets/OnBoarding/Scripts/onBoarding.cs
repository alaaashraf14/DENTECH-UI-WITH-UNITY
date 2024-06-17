using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandellar : MonoBehaviour
{
    public string sceneToLoad = "NextScene";


    public void SkipScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void DragToButton1()
    {
        SceneManager.LoadScene("onBoarding2");
    }

    public void ArrowBack1()
    {
        SceneManager.LoadScene("onBoarding1");
    }

    public void DragToButton2()
    {
        SceneManager.LoadScene("onBoarding3");
    }

    public void ArrowBack2()
    {
        SceneManager.LoadScene("onBoarding2");
    }

    public void DragToButton3()
    {
        SceneManager.LoadScene("onBoarding4");
    }

    public void ArrowBack3()
    {
        SceneManager.LoadScene("onBoarding3");
    }

    public void DragToButton4()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
