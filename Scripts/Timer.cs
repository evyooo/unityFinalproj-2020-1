﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public string LevelToLoad;
    private float timer = 60f;
    private Text timerSeconds;


     // Use this for initialization
    void Start () 
    {
        timerSeconds = GetComponent<Text>();
    }
     
     // Update is called once per frame
    void Update () 
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0") + " sec left";
        if (timer <= 0) 
        {
            Application.LoadLevel (LevelToLoad);
        }

    }
}