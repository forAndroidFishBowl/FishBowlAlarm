using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour {
    public string nowTimeHour;
    public string nowTimeMinute;
    private string[] hour = { "0", "1", "2", "3", "4", "5" };
    private void OnGUI()
    {
        Rect rect1 = new Rect(0.0f, 0.0f, 200.0f, 100.0f);
        Rect rect2 = new Rect(200.0f, 0.0f, 200.0f,100.0f);
        GUIStyle font = new GUIStyle();
        GUIStyle font2 = new GUIStyle();
        font.fontSize = 60;
        font2.fontSize = 20;
        GUI.Label(rect1, nowTimeHour + ":" + nowTimeMinute, font);


    }



    void Alarm()
    {
        using (AndroidJavaClass unity = new AndroidJavaClass("com.test.tw.test.MyDialog"))
        {
            unity.CallStatic("Show", "鬧鐘響了", nowTimeHour + ":" + nowTimeMinute);
        }
    }
    void Update()
    {
        if(System.DateTime.Now.Hour < 10)
            nowTimeHour ="0" + System.DateTime.Now.Hour.ToString();
        else
            nowTimeHour =System.DateTime.Now.Hour.ToString();
        if (System.DateTime.Now.Minute < 10)
            nowTimeMinute = "0" + System.DateTime.Now.Minute.ToString();
        else
            nowTimeMinute = System.DateTime.Now.Minute.ToString();
    }
}
