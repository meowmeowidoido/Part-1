using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeederSpawner : MonoBehaviour
{
    public GameObject speederspawn;
    Vector3 spawnposition; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       spawnposition= new Vector3(Random.Range(-5, 5), Random.Range(-3,4), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(speederspawn,spawnposition,transform.rotation);
    }
}
