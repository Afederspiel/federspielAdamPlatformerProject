using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeDoor : MonoBehaviour
{
    public AudioSource shatter;
    public AudioSource laugh;
    public GameObject wall;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().enabled = false;
            GetComponent<PolygonCollider2D>().enabled = false;
            Destroy(wall);
            shatter.Play();
            Invoke("laughter", 0.5f);
        }

    }

    void laughter()
    {
        laugh.Play();
    }

}
