using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void OnActionButtonClickTopics()
    {
        SceneManager.LoadScene("Topics");
    }

    public void OnActionButtonClickProfile()
    {
        SceneManager.LoadScene("Profile");
    }

    public void OnActionButtonClickPackages()
    {
        SceneManager.LoadScene("Packages");
    }

    public void OnActionButtonClickRanking()
    {
        SceneManager.LoadScene("Ranking");
    }

    public void OnActionButtonClickSetting()
    {
        SceneManager.LoadScene("Check Connection");
    }

    public void OnActionButtonClickAvatar()
    {
        SceneManager.LoadScene("Avatar");
    }
}
