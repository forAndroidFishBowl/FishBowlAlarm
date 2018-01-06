using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class EarnMoney : MonoBehaviour {

    private User user;

    public void gainMoney()
    {
        user = JsonMapper.ToObject<User>(File.ReadAllText(Application.persistentDataPath + "/Status.json"));
        user.money++;
        string jsonString = JsonMapper.ToJson(user);
        File.WriteAllText(Application.persistentDataPath + "/Status.json", jsonString);
    }

}
