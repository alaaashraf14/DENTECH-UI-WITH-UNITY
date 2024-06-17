using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public void CheckSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CheckConnection()
    {
        SceneManager.LoadScene("canaccess");
    }

    public void AddPaymentMethod()
    {
        SceneManager.LoadScene("Method");
    }

    public void AddHW()
    {
        SceneManager.LoadScene("HW");
    }
}
