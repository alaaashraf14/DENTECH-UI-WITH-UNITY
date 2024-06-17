using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public GameObject notificationObject; // The notification object
    public string nextSceneName = "OnBoarding1"; // The name of the scene to load

    void Start()
    {
        StartCoroutine(ShowNotification(1)); // Show the notification for 2 seconds
    }

    IEnumerator ShowNotification(float delay)
    {
        // Show the notification
        notificationObject.SetActive(true);

        // Wait for a specified duration
        yield return new WaitForSeconds(delay);

        // Hide the notification after the time is up
        notificationObject.SetActive(false);

        // Load the specified scene
        SceneManager.LoadScene(nextSceneName);
    }
}
