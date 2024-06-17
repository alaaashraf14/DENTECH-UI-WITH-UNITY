using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Payment : MonoBehaviour
{
    public void DebitCreditCard()
    {
        SceneManager.LoadScene("Card");
    }

    public void ArrowBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ArrowForward()
    {
        SceneManager.LoadScene("Card");
    }

    public void VodafoneCash()
    {
        SceneManager.LoadScene("Vodafone");
    }

    public void ArrowBack2()
    {
        SceneManager.LoadScene("Method");
    }

    public void Arrow()
    {
        SceneManager.LoadScene("HWPricing");
    }

    public void PayNow()
    {
        SceneManager.LoadScene("On the way");
    }

    public void Cancel()
    {
        SceneManager.LoadScene("cancel");
    }
}
