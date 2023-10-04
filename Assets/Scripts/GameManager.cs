using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float gameSpeed = 3;
    public bool isPlay = true;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            gameSpeed = 8;
        }
        else
        {
            gameSpeed = 0;
        }
    }
}
