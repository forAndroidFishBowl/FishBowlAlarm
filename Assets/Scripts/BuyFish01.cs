using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class BuyFish01 : MonoBehaviour {

    private JsonData jsonData;
    private string jsonString;
    private User user = new User();

    public void BuyFish1(string fishName)
    {
        user = JsonMapper.ToObject<User>(File.ReadAllText(Application.dataPath + "/Resource/Status.json"));

        switch (fishName)
        {
            case "Fish1":
                user.fish1 = true;
                break;
            case "Fish2":
                user.fish2 = true;
                break;
            case "Fish3":
                user.fish3 = true;
                break;
            case "Fish4":
                user.fish4 = true;
                break;
            default:
                break;
        }

        jsonString = JsonMapper.ToJson(user);
        File.WriteAllText(Application.dataPath + "/Resource/Status.json", jsonString);
        
    }

}
