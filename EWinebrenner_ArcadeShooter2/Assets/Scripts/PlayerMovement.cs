using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //member variables
    [SerializeField] float _speed = 10.0f;
    Rigidbody2D _rb;
    Vector2 _input;
    void Start()
    {
        Debug.Log("Hello world");
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
        }
        _input = new Vector2(Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"));
       // input = input.normalized; //SET LENGTH TO 1 
        _input = Vector2.ClampMagnitude(_input, 1.0f); //SET LENGTH TO 1 if TOO BIG
        /* Vector3 pos = transform.position;
        pos += new Vector3(input.x, input.y, 0) * _speed * Time.deltaTime;
        transform.position = pos; */
    }

    //PHYSICS GOES HERE
    private void FixedUpdate()
    {
        _rb.velocity = _input * _speed;
    }
}
