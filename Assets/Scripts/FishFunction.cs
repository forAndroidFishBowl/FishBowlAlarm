using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FishFunction : MonoBehaviour {
    float time = 0f;
    int timeCounter = 0;
    int direction = 0;
    System.Random prandom = new System.Random();
    void Start () {
        direction = getNextDirection();
	}

    int getNextDirection()
    {
        return prandom.Next(8);
    }

    void Update() {

        if(time < 3f)
        {
            time += Time.deltaTime;
            switch (direction)
            {
                case 0:
                    gameObject.transform.position += new Vector3(0.01f, 0, 0);
                    break;
                case 1:
                    gameObject.transform.position += new Vector3(-0.01f, 0, 0);
                    break;
                case 2:
                    gameObject.transform.position += new Vector3(0, 0.01f, 0);
                    break;
                case 3:
                    gameObject.transform.position += new Vector3(0, -0.01f, 0);
                    break;
                case 4:
                    gameObject.transform.position += new Vector3(0.01f, 0.01f, 0);
                    break;
                case 5:
                    gameObject.transform.position += new Vector3(-0.01f, 0.01f, 0);
                    break;
                case 6:
                    gameObject.transform.position += new Vector3(0.01f, -0.01f, 0);
                    break;
                case 7:
                    gameObject.transform.position += new Vector3(-0.01f, -0.01f, 0);
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
