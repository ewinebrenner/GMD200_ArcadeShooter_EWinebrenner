using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit solid");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit trigger");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Hit bullet");
            Destroy(collision.gameObject); //Destroy the bullet
            Destroy(gameObject); //Destroy the enemy

            GameManager.Score += 10;
          //  GameObject.Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
            //FindObjectOfType<TMPro.TextMeshProUGUI>().text = score.ToString();
           // FindObjectsOfType
        }
    }
}
