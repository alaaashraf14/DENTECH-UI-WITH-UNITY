using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Simulation : MonoBehaviour
{
    public void OnActionButtonClickSimulation()
    {
        SceneManager.LoadScene("Simulation");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void HomeSimulation()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Method()
    {
        SceneManager.LoadScene("Method");
    }
}
