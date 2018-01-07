using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;


public class Loadillustrated : MonoBehaviour {
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

        GameObject fish01 = GameObject.Find("fish1");
        GameObject fish02 = GameObject.Find("fish2");
        GameObject fish03 = GameObject.Find("fish3");
        GameObject fish04 = GameObject.Find("fish4");
        GameObject fish05 = GameObject.Find("fish5");
        fish01.GetComponent<Renderer>().enabled = user.fish1;
        Debug.Log(user.fish1);
        fish02.GetComponent<Renderer>().enabled = user.fish2;
        Debug.Log(user.fish2);
        fish03.GetComponent<Renderer>().enabled = user.fish3;
        Debug.Log(user.fish3);
        fish04.GetComponent<Renderer>().enabled = user.fish4;
        Debug.Log(user.fish4);
        fish05.GetComponent<Renderer>().enabled = user.fish5;
        Debug.Log(user.fish5);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
