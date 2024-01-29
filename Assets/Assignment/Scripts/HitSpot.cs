using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSpot : MonoBehaviour
{   //using it to reference the enemy gameobject
    public GameObject enemy;

    //destroys gameobject (enemy) when the weakspot is hit
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(enemy);
    }
}
