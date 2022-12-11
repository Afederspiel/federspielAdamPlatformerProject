using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geyserbehaviour : MonoBehaviour
{
    public AudioSource erupt;
    public float eruptionRate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Eruption", 0.1f, eruptionRate);
    }

    void Eruption()
    {
        if (GetComponent<Renderer>().enabled == false)
        {
            GetComponent<Renderer>().enabled = true;
            erupt.Play();

        }
        else // Make it invisible
        {
            GetComponent<Renderer>().enabled = false;

        }

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
    // Update is called once per frame

}
