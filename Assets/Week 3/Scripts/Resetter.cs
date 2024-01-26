using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject carObject;
   Vector2 resetPosition = new Vector2 (-0.91f, -2.33f);
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
       carObject.transform.position=resetPosition;
    }
}
