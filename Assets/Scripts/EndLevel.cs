using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EndLevel : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public int levelNumber = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelNumber++;
            SceneManager.LoadScene(levelNumber);
           
        }

    }
}
