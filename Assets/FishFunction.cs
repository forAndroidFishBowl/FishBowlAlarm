using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FishFunction : MonoBehaviour {
    float time = 0f;
    int timeCounter = 0;
    int direction = 0;
    System.Random prandom = new System.Random();
    // Use this for initialization
    void Start () {
        direction = getNextDirection();
	}

    int getNextDirection()
    {
        return prandom.Next(8);
    }

    // Update is called once per frame
    void Update() {
        /*
        time += Time.deltaTime;
        if (time > 1f)
        {
             int fishmove=0;
            if(time > 1.5f)fishmove = Random.Range(1, 3);

            switch (fishmove)
            {
                case 1:
                        gameObject.transform.position -= new Vector3(0.1f, 0, 0);
                    break;
                case 2:
                    gameObject.transform.position += new Vector3(0.1f, 0, 0);
                    break;
                default:
                    break;
            }
           if (time > 3f) time = 0.5f;
        }
        */

        if(time < 3f)
        {
            time += Time.deltaTime;
            switch (direction)
            {
                case 0:
                    gameObject.transform.position += new Vector3(0.1f, 0, 0);
                    break;
                case 1:
                    gameObject.transform.position += new Vector3(-0.1f, 0, 0);
                    break;
                case 2:
                    gameObject.transform.position += new Vector3(0, 0.1f, 0);
                    break;
                case 3:
                    gameObject.transform.position += new Vector3(0, -0.1f, 0);
                    break;
                case 4:
                    gameObject.transform.position += new Vector3(0.1f, 0.1f, 0);
                    break;
                case 5:
                    gameObject.transform.position += new Vector3(-0.1f, 0.1f, 0);
                    break;
                case 6:
                    gameObject.transform.position += new Vector3(0.1f, -0.1f, 0);
                    break;
                case 7:
                    gameObject.transform.position += new Vector3(-0.1f, -0.1f, 0);
                    break;
            }
        }
        else
        {
            time = 0f;
            direction = getNextDirection();
        }


    }
}
