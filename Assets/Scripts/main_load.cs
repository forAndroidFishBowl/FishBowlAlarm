using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class main_load : MonoBehaviour {

    private JsonData jsonData;
    

	// Use this for initialization
	void Start () {
        GameObject fish1 = GameObject.Find("Fish1");
        GameObject fish2 = GameObject.Find("Fish2");
        GameObject fish3 = GameObject.Find("Fish3");
        GameObject fish4 = GameObject.Find("Fish4");
        jsonData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Resource/Status.json"));
        Debug.Log((bool)jsonData["fish"][0]["enable"]);
        fish1.GetComponent<Renderer>().enabled = (bool)jsonData["fish"][0]["enable"];
        fish2.GetComponent<Renderer>().enabled = (bool)jsonData["fish"][1]["enable"];
        fish3.GetComponent<Renderer>().enabled = (bool)jsonData["fish"][2]["enable"];
        fish4.GetComponent<Renderer>().enabled = (bool)jsonData["fish"][3]["enable"];
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
