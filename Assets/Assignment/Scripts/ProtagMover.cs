using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ProtagMover : MonoBehaviour
{   
    //variables and rigidbody reference 
    Rigidbody2D rigidbody;
    
    public float speed;//speed of player
    private float teleportPower = 2500000f;//teleport height/ intensity
    Vector2 direction;   
    // Start is called before the first frame update
    void Start()
    {
        print("Move with WASD, press space for a teleport boost and hit those white orbs! the light respawns enemies. Spikes kill you!");//message for when the player gets control of the player
       rigidbody = GetComponent<Rigidbody2D>();//gets the rigidbody of the gameobject the script is put onto.
        //setting the gravity scale to 50 for the rigidbody
        rigidbody.gravityScale = 50f;
    }

    // Update is called once per frame
    void Update()
    {

       //player moves left and right with W and D
        direction.x = Input.GetAxis("Horizontal");
        //Will only work if the space button is pressed and the y position of the rigidbody is less than -1.21

        if (Input.GetKeyDown(KeyCode.Space) == true && rigidbody.position.y < -1.21f)
        {
            //rigidbody teleport up
            //Vector2.up makes it so it only moves up 
            //multiplied by the force 
            //Multipled by time.deltatime so it is measured every second and not frame
            //placed in update because having the if statement with the input key in the fixed update method has a delay in key presses.
            rigidbody.AddForce(Vector2.up * teleportPower * Time.deltaTime);

        }
    }
    private void FixedUpdate()
    {
        //moves the player 
        //rigidbody.position is the current position of the rigid body
        //and is added by the speed which is controlled in unity 
        //multiplied by the direction to allow left and right movement
        //Time.deltatime makes sure per second and not perframe 

        rigidbody.MovePosition(rigidbody.position + speed * direction * Time.deltaTime);  
    }
   
}
