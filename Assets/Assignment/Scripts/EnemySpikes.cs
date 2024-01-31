using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpikes : MonoBehaviour
{
   GameObject player;//player gameobject that is referenced with a tag
    private void Start()
    {   //finds the gameobject with the tag player (aka the player object) and gets the gameobject as a component
       player =GameObject.FindGameObjectWithTag("Player").GetComponent<GameObject>();
     }

    // Update is called once per frame
    private void OnCollisionStay2D(Collision2D collision)
    {   //destroys the game object is collides with
            Destroy(player);
            //when the player is destroyed it reloads the scene 
            if (player.IsDestroyed())
        {
            
           SceneManager.LoadScene("assignment1");//looks for the scene name with the name assignment1
        }
        }

    }
