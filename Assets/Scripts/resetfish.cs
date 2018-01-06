using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class resetfish : MonoBehaviour {

	// Use this for initialization
	public void reset ()
    {
        string path = Application.persistentDataPath + "/Status.json";

        if (File.Exists(path))
        {
            //檔案存在
            string init = "{\"fish1\":false,\"fish2\":false,\"fish3\":false,\"fish4\":false,\"fish5\":false,\"money\":89514}";
            File.WriteAllText(path, init);
        }
        else
        {
            //檔案不存在
            FileStream Status = File.Create(@path);
            Status.Close();
            string init = "{\"fish1\":false,\"fish2\":false,\"fish3\":false,\"fish4\":false,\"fish5\":false,\"money\":89514}";
            File.WriteAllText(path, init);
        }
    }

}
