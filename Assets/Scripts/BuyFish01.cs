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
                user.moneycost += 100;
                user.achievement1 = true;
                break;
            case "Fish2":
                user.fish2 = true;
                user.moneycost += 200;
                user.money -= 200;
                user.achievement1 = true;
                break;
            case "Fish3":
                user.fish3 = true;
                user.money -= 300;
                user.moneycost += 300;
                user.achievement1 = true;
                break;
            case "Fish4":
                user.fish4 = true;
                user.money -= 400;
                user.moneycost += 400;
                user.achievement1 = true;
                break;
            case "Fish5":
                user.fish5 = true;
                user.money -= 500;
                user.moneycost += 500;
                
                user.achievement1 = true;
                break;
            default:
                break;
        }

        if (user.moneycost >= 1000)
            user.achievement2 = true;
        if (user.fish1 == true && user.fish2 == true && user.fish3 == true && user.fish4 == true && user.fish5 == true)
            user.achievement4 = true;

        jsonString = JsonMapper.ToJson(user);
        File.WriteAllText(Application.persistentDataPath + "/Status.json", jsonString);
        
    }

}
