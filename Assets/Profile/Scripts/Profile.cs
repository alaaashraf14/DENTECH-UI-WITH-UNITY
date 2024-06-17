using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Profile : MonoBehaviour
{
    public void OnActionButtonClickDeleteProfile()
    {
        SceneManager.LoadScene("Delete Profile");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void DeleteORDontProfile()
    {
        SceneManager.LoadScene("Profile");
    }
}
