using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{  public Rigidbody2D rigidbody;
   public float force = 150f;
    Vector2 direction;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Player Hit");
        
    }
}
