using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 300);
    private Rigidbody2D rb2d;
    public float Speed;
    int jumpCount = 1;
    public Vector3 respawn;
    public AudioSource jump;
    public AudioSource croak;
    public AudioSource warp;
    public AudioSource squish;
    public AudioSource boing;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Worldhop();
        }

        bool shouldJump = Input.GetKeyDown("space") && jumpCount > 0;

        if (shouldJump == true)
        {
            //Reset velocity
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(jumpForce);
            jumpCount--;
            jump.Play();
        }

        float xMove = Input.GetAxis("Horizontal");

        Vector2 newPosition = gameObject.transform.position;

        newPosition.x += xMove * Speed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, -1800f, 1800f);
        gameObject.transform.position = newPosition;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Platform"))
        {

            jumpCount = 1;

        }

        if (collision.gameObject.tag == ("Mushroom"))
        {
            jumpCount = 1;
            boing.Play();

        }

        if (collision.gameObject.tag == ("Obstacle"))
        {
            Respawn();
        }

        if (collision.gameObject.tag == ("Enemy"))
        {
            Respawn();
        }

        if (collision.gameObject.tag == ("Boulder"))
        {
            Respawn();
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            respawn = this.transform.position;
        }

        if (collision.gameObject.CompareTag("PIT"))
        {
            Respawn();
        }

        if (collision.gameObject.CompareTag("kill trigger"))
        {
            squish.Play();
        }
    }

    public void Respawn()
    {
        croak.Play();
        this.transform.position = respawn;
    }
    public void Worldhop()
    {
        warp.Play();
    }

}

