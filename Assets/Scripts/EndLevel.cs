using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EndLevel : MonoBehaviour
{
    public GameObject WinText;
    public SpriteRenderer spriteRenderer;
    public int levelNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        WinText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelNumber++;
            Destroy(collision.gameObject);

            if (levelNumber > 2)
            {
                WinText.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(levelNumber);
            }
           
        }

    }
}
