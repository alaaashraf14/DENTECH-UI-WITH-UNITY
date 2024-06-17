using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Packages : MonoBehaviour
{
    public void ChoosePackage()
    {
        SceneManager.LoadScene("daily package");
    }
}
