using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawning : MonoBehaviour
{
    public GameObject Boulder;
    public GameObject barricade;
    public GameObject run;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(Boulder, new Vector3(510, 24, 0), Quaternion.identity);
            barricade.SetActive(true);
            run.SetActive(true);
        }
    }
}
