﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayer : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "koin")
        {
            Debug.Log("Coin diambil");
            Destroy(col.gameObject);

        }
    }
    //void OnCollisionStay2D(Collision2D col)
  //  {
       // if (col.gameObject.tag == "koin")
      //  {
       //     Debug.Log("Sedang Nabrak");
       // }
   // }
   // void OnCollosionExit2D(Collision2D col)
    //{
      //  if (col.gameObject.tag == "koin")
      //  {
      //      Debug.Log("Sudah Nabrak");
      //  }
   // }
}
