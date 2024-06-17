using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // للتحكم في تحميل المشاهد

public class NotificationDisplay : MonoBehaviour
{
    public GameObject notificationObject; // العنصر الذي سيعرض الإشعار
    public string sceneToLoad = "HP"; // تعيين اسم المشهد الذي سيتم تحميله

    void Start()
    {
        StartCoroutine(ShowNotification(2)); // عرض الإشعار لمدة دقيقتين
    }

    IEnumerator ShowNotification(float delay)
    {
        notificationObject.SetActive(true); // إظهار الإشعار
        yield return new WaitForSeconds(delay); // الانتظار لمدة محددة
        notificationObject.SetActive(false); // إخفاء الإشعار بعد انقضاء الوقت

        // تحميل المشهد "HW"
        SceneManager.LoadScene(sceneToLoad);
    }
}
