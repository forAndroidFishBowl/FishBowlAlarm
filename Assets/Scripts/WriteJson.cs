using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LitJson;

public class WriteJson : MonoBehaviour {
    private string jsonString;
    private JsonData jsonData;

    void Start()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/Resource/Status.json");
        jsonData = JsonMapper.ToObject(jsonString);
        Debug.Log(jsonData["fish"][0]["enable"]);
        Debug.Log(jsonData["fish"][1]["enable"]);
        Debug.Log(jsonData["fish"][2]["enable"]);
        Debug.Log(jsonData["fish"][3]["enable"]);

    }
}

public class User
{
    public bool fish1;
    public bool fish2;
    public bool fish3;
    public bool fish4;

    public User(bool fish1,bool fish2,bool fish3,bool fish4)
    {
        this.fish1 = fish1;
        this.fish2 = fish2;
        this.fish3 = fish3;
        this.fish4 = fish4;
    }
}