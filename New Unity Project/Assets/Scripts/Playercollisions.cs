using UnityEngine;

public class Playercollisions : MonoBehaviour
{
    public PlayerMovement movement;     // A reference to our Player movement script 
   

    //This function runs when we hit another object.

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle"|| collisionInfo.collider.tag == "Cubefalling"|| collisionInfo.collider.tag == "CubeGround"|| collisionInfo.collider.tag == "Borders")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
} 

    
