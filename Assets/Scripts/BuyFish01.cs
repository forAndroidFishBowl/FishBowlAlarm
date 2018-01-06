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
        user = JsonMapper.ToObject<User>(File.ReadAllText(Application.persistentDataPath + "/Status.json"));

        switch (fishName)
        {
            case "Fish1":
                user.fish1 = true;
                user.money -= 100;
                break;
            case "Fish2":
                user.fish2 = true;
                user.money -= 200;
                break;
            case "Fish3":
                user.fish3 = true;
                user.money -= 300;
                break;
            case "Fish4":
                user.fish4 = true;
                user.money -= 400;
                break;
            case "Fish5":
                user.fish5 = true;
                user.money -= 500;
                break;
            default:
                break;
        }

        jsonString = JsonMapper.ToJson(user);
        File.WriteAllText(Application.persistentDataPath + "/Status.json", jsonString);
        
    }

}
