using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class LoadAchieve : MonoBehaviour
{
    private JsonData jsonData;
    private string jsonString;
    private User user = new User();
    // Use this for initialization
    void Start()
    {
        string path = Application.persistentDataPath + "/Status.json";

        if (File.Exists(path))
        {
            //檔案存在
        }
        else
        {
            //檔案不存在
            FileStream Status = File.Create(@path);
            Status.Close();
            User init_user = new User();
            string init = "{\"fish1\":false,\"fish2\":false,\"fish3\":false,\"fish4\":false,\"fish5\":false,\"money\":89514,\"achievement1\": false,\"achievement2\": false,\"achievement3\":false,\"achievement4\": false,\"moneycost\":0}";

            File.WriteAllText(path, init);
            //jsonString = JsonMapper.ToJson(init_user);
            // File.WriteAllText(Application.persistentDataPath + "/Status.json", jsonString);

        }
        User user = JsonMapper.ToObject<User>(File.ReadAllText(path));

        GameObject blackAchievement1 = GameObject.Find("blackcup");
        GameObject blackAchievement2 = GameObject.Find("blackcup (1)");
        GameObject blackAchievement3 = GameObject.Find("blackcup (2)");
        GameObject blackAchievement4 = GameObject.Find("blackcup (3)");

        GameObject Achievement1 = GameObject.Find("cup (2)");
        GameObject Achievement2 = GameObject.Find("cup (1)");
        GameObject Achievement3 = GameObject.Find("cup");
        GameObject Achievement4 = GameObject.Find("cup (3)");

        GameObject wAchievement1 = GameObject.Find("1");
        GameObject wAchievement2 = GameObject.Find("2");
        GameObject wAchievement3 = GameObject.Find("3");
        GameObject wAchievement4 = GameObject.Find("4");

        GameObject nwAchievement1 = GameObject.Find("notyet");
        GameObject nwAchievement2 = GameObject.Find("notyet (1)");
        GameObject nwAchievement3 = GameObject.Find("notyet (2)");
        GameObject nwAchievement4 = GameObject.Find("notyet (3)");

        blackAchievement1.GetComponent<Renderer>().enabled = !user.achievement1;

        blackAchievement2.GetComponent<Renderer>().enabled = !user.achievement2;

        blackAchievement3.GetComponent<Renderer>().enabled = !user.achievement3;

        blackAchievement4.GetComponent<Renderer>().enabled = !user.achievement4;

        nwAchievement1.GetComponent<Renderer>().enabled = !user.achievement1;

        nwAchievement2.GetComponent<Renderer>().enabled = !user.achievement2;

        nwAchievement3.GetComponent<Renderer>().enabled = !user.achievement3;

        nwAchievement4.GetComponent<Renderer>().enabled = !user.achievement4;

        Achievement1.GetComponent<Renderer>().enabled = user.achievement1;

        Achievement2.GetComponent<Renderer>().enabled = user.achievement2;

        Achievement3.GetComponent<Renderer>().enabled = user.achievement3;

        Achievement4.GetComponent<Renderer>().enabled = user.achievement4;

        wAchievement1.GetComponent<Renderer>().enabled = user.achievement1;

        wAchievement2.GetComponent<Renderer>().enabled = user.achievement2;

        wAchievement3.GetComponent<Renderer>().enabled = user.achievement3;

        wAchievement4.GetComponent<Renderer>().enabled = user.achievement4;

    }

    // Update is called once per frame
    void Update()
    {

    }

}
