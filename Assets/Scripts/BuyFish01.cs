using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class BuyFish01 : MonoBehaviour {

    private JsonData jsonData;

    public void BuyFish1(string fishName)
    {
        jsonData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Resource/Status.json"));

        switch (fishName)
        {
            case "Fish1":
                jsonData["fish"][0]["enable"] = true;
                break;
            case "Fish2":
                jsonData["fish"][1]["enable"] = true;
                break;
            case "Fish3":
                jsonData["fish"][2]["enable"] = true;
                break;

        }

        
    }

}
