﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject rocks;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 2.5f);
    }
    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label("Score: " + score.ToString());
    }
    void CreateObstacle()
    {
        Instantiate(rocks);
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
