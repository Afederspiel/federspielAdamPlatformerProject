using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float positionleft;
    public float positionright;
    public float enemyspeed;

    void Start()
    {
        movingLeft();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector3(positionleft, transform.position.y, transform.position.z), enemyspeed * Time.deltaTime);
        if (transform.position.x - 0.01f <= positionleft)
        {
            movingRight();
        }
            else if (transform.position.x + 0.01f >= positionright)
        {
            movingLeft();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);
            ReloadGame();

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }
    private void ReloadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    void movingLeft()
    {
       transform.position = Vector2.MoveTowards(transform.position, new Vector3(positionleft, transform.position.y, transform.position.z), enemyspeed * Time.deltaTime);
    }

    void movingRight()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector3(positionright, transform.position.y, transform.position.z), enemyspeed * Time.deltaTime);
    }
}
