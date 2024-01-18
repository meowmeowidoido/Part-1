using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{ public Color pickColor;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
         
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = pickColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
           
        Debug.Log("Trigger From: " +collision.gameObject);
        spriteRenderer.color = Color.red;
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exit from: "+collision.gameObject);
        spriteRenderer.color = pickColor;
    }
}
