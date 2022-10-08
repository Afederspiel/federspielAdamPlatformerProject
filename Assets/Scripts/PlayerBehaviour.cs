using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 300);
    private Rigidbody2D rb2d;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool shouldJump = Input.GetKeyDown("space") || Input.GetMouseButtonDown(0);

        if (shouldJump == true)
        {
            //Reset velocity
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(jumpForce);
        }

        float xMove = Input.GetAxis("Horizontal");

        Vector2 newPosition = gameObject.transform.position;

        newPosition.x += xMove * Speed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, -18f, 18f);
        gameObject.transform.position = newPosition;
    }
}
