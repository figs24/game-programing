using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void onCredits()
    {
        SceneManager.LoadScene("kredit");
    }
    public void onHelps()
    {
        SceneManager.LoadScene("help");
    }
}
