using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    Vector2 speed = new Vector2(10, 0);
    Rigidbody2D rigidbody2D;
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
