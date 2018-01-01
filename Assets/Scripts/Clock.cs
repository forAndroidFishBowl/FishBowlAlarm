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

    private void OnGUI()
    {
        User user = JsonMapper.ToObject<User>(File.ReadAllText(Application.dataPath + "/Resource/Status.json"));

        Rect rect1 = new Rect(0.0f, 0.0f, 200.0f, 100.0f);
        Rect rect2 = new Rect(200.0f, 0.0f, 200.0f,100.0f);
        Rect rect3 = new Rect(0.0f, 100.0f, 30.0f, 30.0f);

        GUIStyle font = new GUIStyle();
        GUIStyle font2 = new GUIStyle();
        font.fontSize = 60;
        font2.fontSize = 20;

        GUI.Label(rect1, nowTimeHour + ":" + nowTimeMinute, font);

        inputHour = Regex.Replace(inputHour, "[^0-9]", "");
        inputMinute = Regex.Replace(inputMinute, "[^0-9]", "");
 
        GUI.Label(rect3, "設定鬧鐘時間 ",font2);
        inputHour = GUI.TextField(new Rect(130, 100, 30, 30), inputHour, 2);
        GUI.Label(new Rect(160, 100, 30, 30), "  : ", font2);
        inputMinute = GUI.TextField(new Rect(190, 100, 30, 30), inputMinute, 2);
        GUI.Label(new Rect(0, 200, 200,100), "鬧鐘時間 " + saveTimeHour + " : " + saveTimeMinute,font2);

        GUI.Label(new Rect(400, 0, 150, 50),"金錢" + user.money.ToString(),font2);

        if (GUI.Button(new Rect(50,150,50,50),"確認"))
        {
            saveTimeHour = inputHour;
            saveTimeMinute = inputMinute;
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
