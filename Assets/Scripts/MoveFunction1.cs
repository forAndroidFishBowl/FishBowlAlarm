using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFunction1 : MonoBehaviour {

    float MaxLeftSide = 330f;
    float MaxRightSide = 820f;
    float MaxTopSide = 550f;
    float MaxBottomSide = 0f;

    float time = 0f;
    int timeCounter = 0;
    int direction = 0;
    System.Random prandom = new System.Random();
    // Use this for initialization
    void Start()
    {
        direction = getNextDirection();
    }
    void checkSide(Vector3 Fish_position)//邊界處理
    {
        int OutSide = 0;
        if (Fish_position.x > MaxRightSide) OutSide = 1;
        else if (Fish_position.x < MaxLeftSide) OutSide = 2;
        else if (Fish_position.y < MaxBottomSide) OutSide = 3;
        else if (Fish_position.y > MaxTopSide) OutSide = 4;

        switch (OutSide)
        {
            case 1:
                gameObject.transform.position = new Vector3(MaxLeftSide, gameObject.transform.position.y, 0);
                break;
            case 2:
                gameObject.transform.position = new Vector3(MaxRightSide, gameObject.transform.position.y, 0);
                break;
            case 3:
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, MaxTopSide, 0);
                break;
            case 4:
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, MaxBottomSide, 0);
                break;
            default:
                break;
        }
    }
    int getNextDirection()
    {
        return prandom.Next(8);
    }

    // Update is called once per frame
    void Update()
    {

        checkSide(gameObject.transform.position);
        if (time < 3f)
        {
            time += Time.deltaTime;
            switch (direction)
            {
                case 3:
                    gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    gameObject.transform.position += new Vector3(0.1f, 0, 0);
                    break;
                case 2:
                    gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                    gameObject.transform.position += new Vector3(-0.1f, 0, 0);
                    break;
                case 4:
                    gameObject.transform.position += new Vector3(0, 0.1f, 0);
                    break;
                case 1:
                    gameObject.transform.position += new Vector3(0, -0.1f, 0);
                    break;
                case 6:
                    gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    gameObject.transform.position += new Vector3(0.1f, 0.1f, 0);
                    break;
                case 7:
                    gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                    gameObject.transform.position += new Vector3(-0.1f, 0.1f, 0);
                    break;
                case 8:
                    gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    gameObject.transform.position += new Vector3(0.1f, -0.1f, 0);
                    break;
                case 5:
                    gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                    gameObject.transform.position += new Vector3(-0.1f, -0.1f, 0);
                    break;
            }
        }
        else
        {
            time = 0f;
            direction = Random.Range(1, 8);
        }


    }
}
