using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Vector3 jumpForce = new Vector3(0, 300);
    void Start()
    {

    }

    // Update is called once per frame
    void Die()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("GasNeh");
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Die();
    }
    void Update()
    {
        float touchclicked = Input.GetAxis("Fire1");
        if (touchclicked==1f)
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y<0)
        {
            Die();
        }
    }
}
