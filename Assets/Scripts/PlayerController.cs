using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool isPressed = false;
    public ScoreCounter scoreCounter;

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
            scoreCounter.score += 1;
        }

        if (collision.gameObject.tag == "Menma")
        {
            Destroy(collision.gameObject);
            scoreCounter.score += 5;
        }

        if (collision.gameObject.tag == "Men")
        {
            Destroy(collision.gameObject);
            scoreCounter.score += 10;
        }

        if (collision.gameObject.tag == "Ajitama")
        {
            Destroy(collision.gameObject);
            scoreCounter.score += 30;
        }

        if (collision.gameObject.tag == "Chashu")
        {
            Destroy(collision.gameObject);
            scoreCounter.score += 20;
        }

        if (collision.gameObject.tag == "Udon")
        {
            Destroy(collision.gameObject);
            scoreCounter.score -= 10;
        }

        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("Result");
        }
            

    }
}
