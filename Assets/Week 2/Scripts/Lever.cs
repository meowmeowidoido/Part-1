using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Door.activeInHierarchy==false)
        {
            Door.SetActive(true);
        }
        else if (Door.activeInHierarchy==true)
        {
            Door.SetActive(false);
        }
    }
}
