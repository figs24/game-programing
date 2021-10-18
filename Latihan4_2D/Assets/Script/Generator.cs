using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject rocks;
    public int score = 0;
    GUIStyle guiStyle = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 2.5f);
    }
    void OnGUI()
    {
        GUI.color = Color.black;
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(0, 0, 300, 50), "Score: " + score.ToString(), guiStyle);
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
