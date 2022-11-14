using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldhopBehaviourObstacles : MonoBehaviour
{
    public AudioSource WorldhopSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            // Make it visible
            if (GetComponent<Renderer>().enabled == false)
            {
                GetComponent<Renderer>().enabled = true;
            }
            else // Make it invisible
            {
                GetComponent<Renderer>().enabled = false;
            }

        }

        if (Input.GetKeyDown("q"))
        {
            if (GetComponent<PolygonCollider2D>().enabled == false)
            {
                GetComponent<PolygonCollider2D>().enabled = true;
            }
            else // Make it intangible
            {
                GetComponent<PolygonCollider2D>().enabled = false;
            }
        }
    }

}
