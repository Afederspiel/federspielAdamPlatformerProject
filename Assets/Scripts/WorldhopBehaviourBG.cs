using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldhopBehaviourBG : MonoBehaviour
{
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
    }
}
