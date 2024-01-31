using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemyReset : MonoBehaviour
{   
    public GameObject enemySpawner;//allows to reference the gameobject into the script
    Vector2 spawnCoordinates;//vector for spawn coordinates
    private void Update()
    {
        //randomizes where the enemy spawns on the X axis and y axis
        spawnCoordinates = new Vector2(Random.Range(-6f, 5), Random.Range(-1.16f, 1.80f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {       //Enemy is respawned whenever something enters the light source
            Instantiate(enemySpawner, spawnCoordinates, enemySpawner.transform.rotation);
   

    }
}