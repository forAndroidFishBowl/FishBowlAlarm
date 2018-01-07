using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System.Globalization;
using LitJson;
using System.IO;

public class Clock : MonoBehaviour {
    public string nowTimeHour;
    public string nowTimeMinute;
    public string saveTimeHour;
    public string saveTimeMinute;
    public string inputHour;
    public string inputMinute;
    private string jsonString;

    private void OnGUI()
    {
        User user = JsonMapper.ToObject<User>(File.ReadAllText(Application.persistentDataPath + "/Status.json"));

        Rect rect1 = new Rect(0.0f, 0.0f, 600.0f, 200.0f);
        Rect rect2 = new Rect(600.0f, 0.0f, 600.0f,200.0f);
        Rect rect3 = new Rect(0.0f, 200.0f, 90.0f, 90.0f);

        GUIStyle font = new GUIStyle();
        GUIStyle font2 = new GUIStyle();
        font.fontSize = 180;
        font2.fontSize = 40;

        GUI.Label(rect1, nowTimeHour + ":" + nowTimeMinute, font);

        inputHour = Regex.Replace(inputHour, "[^0-9]", "");
        inputMinute = Regex.Replace(inputMinute, "[^0-9]", "");
 
        GUI.Label(rect3, "設定鬧鐘時間 ",font2);
        inputHour = GUI.TextField(new Rect(250, 200, 100, 50), inputHour, 2);
        GUI.Label(new Rect(350, 200, 50, 50), "  : ", font2);
        inputMinute = GUI.TextField(new Rect(400, 200, 100, 50), inputMinute, 2);
        GUI.Label(new Rect(0, 300, 600,300), "鬧鐘時間 " + saveTimeHour + " : " + saveTimeMinute,font2);
     
        GUI.Label(new Rect(1200, 0, 450, 150), "金錢" + user.money.ToString(), font2);
        if (GUI.Button(new Rect(150,350,150,50),"確認"))
        {
            saveTimeHour = inputHour;
            saveTimeMinute = inputMinute;
            user.achievement3 = true;
            jsonString = JsonMapper.ToJson(user);
            File.WriteAllText(Application.persistentDataPath + "/Status.json", jsonString);

        }
    }

    void Checkclock()
    {
        if ((nowTimeHour == saveTimeHour) && (nowTimeMinute == saveTimeMinute))
        {
            Alarm();
            saveTimeHour = saveTimeMinute = null;
        }
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
        Checkclock();
    }
}
