using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HW : MonoBehaviour
{
    public void BackToHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void MoreDetails()
    {
        SceneManager.LoadScene("Haptic Pen");
    }

    public void ArrowBack()
    {
        SceneManager.LoadScene("HW");
    }

    public void BuyNow()
    {
        SceneManager.LoadScene("Method");
    }
   
}
