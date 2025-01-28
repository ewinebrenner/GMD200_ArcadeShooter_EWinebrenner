using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int score = 0;
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

            score += 10;
            GameObject.Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
        }
    }
}
