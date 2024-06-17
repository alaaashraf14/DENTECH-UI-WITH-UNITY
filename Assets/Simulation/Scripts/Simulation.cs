using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimulationLevels : MonoBehaviour
{
    public void Level0()
    {
        SceneManager.LoadScene("Check Setting");
    }

    public void Arrow()
    {
        SceneManager.LoadScene("Avatar");
    }
}
