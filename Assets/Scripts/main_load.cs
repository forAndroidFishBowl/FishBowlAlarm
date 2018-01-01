using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class User
{
    public bool fish1 { get; set; }
    public bool fish2 { get; set; }
    public bool fish3 { get; set; }
    public bool fish4 { get; set; }
    public bool fish5 { get; set; }

    public int money { get; set; }

}

public class main_load : MonoBehaviour {

	// Use this for initialization
	void Start () {

        User user = JsonMapper.ToObject<User>(File.ReadAllText(Application.dataPath + "/Resource/Status.json"));

        GameObject fish01 = GameObject.Find("Fish1");
        GameObject fish02 = GameObject.Find("Fish2");
        GameObject fish03 = GameObject.Find("Fish3");
        GameObject fish04 = GameObject.Find("Fish4");

        fish01.GetComponent<Renderer>().enabled = user.fish1;
        Debug.Log(user.fish1);
        fish02.GetComponent<Renderer>().enabled = user.fish2;
        Debug.Log(user.fish2);
        fish03.GetComponent<Renderer>().enabled = user.fish3;
        Debug.Log(user.fish3);
        fish04.GetComponent<Renderer>().enabled = user.fish4;
        Debug.Log(user.fish4);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
