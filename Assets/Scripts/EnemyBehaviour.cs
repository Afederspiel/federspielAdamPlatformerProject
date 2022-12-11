using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float positionleft;
    public float positionright;
    public float enemyspeed;
    public Vector3 respawn;
    public int patrollength;
    public int patrolduration;

    void Start()
    {
        movingLeft();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = Vector2.MoveTowards(transform.position, new Vector3(positionleft, transform.position.y, transform.position.z), enemyspeed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x - enemyspeed * Time.deltaTime, transform.position.y);
        patrollength++;

        if (patrollength >= patrolduration)
        {
            patrollength = 0;
            enemyspeed *= -1;
        }

        //if (transform.position.x - 0.01f <= positionleft)
        //{
          //  movingRight();
        //}
        
        //if (transform.position.x + 0.01f >= positionright)
        //{
          //  movingLeft();
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke("Death", 0.01f);
        }

    }

    void movingLeft()
    {
       transform.position = Vector2.MoveTowards(transform.position, new Vector3(positionleft, transform.position.y, transform.position.z), enemyspeed * Time.deltaTime);
    }

    void movingRight()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector3(positionright, transform.position.y, transform.position.z), enemyspeed * Time.deltaTime);
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
