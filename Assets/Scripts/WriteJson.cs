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



        File.WriteAllText(Application.dataPath + "/Resource/Status.json", jsonString);

    }
}

