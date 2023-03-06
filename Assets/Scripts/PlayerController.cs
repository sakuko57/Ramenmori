using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPressed = true;
        }
        
    }
    void FixedUpdate()
    {
        if(isPressed)
        { 
            rb.AddForce(200 * Vector2.up);
            isPressed = false;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Negi")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Menma")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Men")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Ajitama")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Chashu")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Udon")
        {
            Destroy(collision.gameObject);
        }
    }
}
