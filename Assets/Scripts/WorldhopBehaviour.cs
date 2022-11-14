using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldhopBehaviour : MonoBehaviour
{
    public GameObject shifter;
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
            // Make it tangible
            if (GetComponent<BoxCollider2D>().enabled == false)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
            else // Make it intangible
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
