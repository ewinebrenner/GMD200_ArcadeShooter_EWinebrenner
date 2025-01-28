using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
            GameObject bulletInstance = Instantiate(bullet,transform.position + transform.up * 1.5f,
                transform.rotation);

            Rigidbody2D bulletRB = bulletInstance.GetComponent<Rigidbody2D>();
            //bulletRB.velocity = new Vector2(0, 50);
            //bulletRB.velocity = Vector2.up * 50; //Global up
            bulletRB.velocity = transform.up * 50; //Local up
            Destroy(bulletRB.gameObject, 1.0f);
        }
    }
}
