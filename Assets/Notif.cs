using UnityEngine;
using System.Collections;


public class Notif : MonoBehaviour {


    private float timer;
    private float time = 1;

	// Use this for initialization
	void Start () {


        var notif = new UnityEngine.iOS.LocalNotification();
        notif.alertBody = "Hello!";
        UnityEngine.iOS.NotificationServices.PresentLocalNotificationNow(notif);
        Debug.Log(UnityEngine.iOS.NotificationServices.localNotificationCount);
	}
	
	// Update is called once per frame
	void Update () {

        if (UnityEngine.iOS.NotificationServices.localNotificationCount > 0)
        {
            Debug.Log(UnityEngine.iOS.NotificationServices.localNotifications[0].alertBody);
            UnityEngine.iOS.NotificationServices.ClearLocalNotifications();
        }

        timer -= Time.deltaTime;

        if(timer<0)
        {
            timer = time;

            var notif = new UnityEngine.iOS.LocalNotification();
            notif.alertBody = "Hello!";
            UnityEngine.iOS.NotificationServices.PresentLocalNotificationNow(notif);
        }

	}
}
