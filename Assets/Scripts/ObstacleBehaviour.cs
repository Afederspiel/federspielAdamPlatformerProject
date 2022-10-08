using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    private void ReloadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
