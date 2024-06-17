using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickHandler : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ArrowBack()
    {
        SceneManager.LoadScene("Topics");
    }

    /*public void fillingVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=fm208EgQUoU");
    }*/
    public void fillingVideo()
    {
        SceneManager.LoadScene("Fillingvideo");
    }

    public void AnatomyVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=vqrXeDrlEiY");
    }

    public void CrownVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=OqYAB5YEYmo");
    }

    public void OrthodonticsVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=SuBlvSjfSdQ");
    }

    public void ExtractionVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=YvVPkP4gRus");
    }

    public void WhiteningVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=VzuGFcK4lqY");
    }

    public void EndoVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=W5PLJWdO97I");
    }
}
