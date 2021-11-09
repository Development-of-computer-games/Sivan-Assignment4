using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component logs all four kinds of collisions involving its object.
 */
public class CollisionLogger : MonoBehaviour {

    // creating GameObject for each of the walls in order to be able to track them if a collision was made
    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject topWall;
    public GameObject downWall;
    private float offset = 1.5f; // offset in order to teleport the player to the opposite place
    private void Start() {
        Debug.Log("Start CollisionLogger on "+this.name);
    }

    // I put it under triggerOn2D because i used a "box collider 2D" therefore the catch will be here.
    private void OnTriggerEnter2D(Collider2D other) {
        // initializing the gameObjects of the walls
        leftWall = GameObject.Find("LeftWall");
        rightWall = GameObject.Find("RightWall");
        topWall = GameObject.Find("TopWall");
        downWall = GameObject.Find("DownWall");

        // if a coliision was made with the right wall
        if (other.gameObject.name == "RightWall")
        {
            //set character position to left_wall + offset 
            transform.position = leftWall.transform.position + new Vector3(offset, transform.position.y, transform.position.z);
            //Debug.Log("RightWall " + transform.position);
        }
        // if a coliision was made with the left wall
        if (other.gameObject.name == "LeftWall")
        {
            transform.position = rightWall.transform.position + new Vector3(-offset, transform.position.y, transform.position.z);
           // Debug.Log("LeftWall " + transform.position);
        }
        // if a coliision was made with the ceilling
        if (other.gameObject.name == "TopWall")
        {
            transform.position = downWall.transform.position + new Vector3(transform.position.x, offset, transform.position.z);
           // Debug.Log("TopWall " + transform.position);
        }
        // if a coliision was made with the floor
        if (other.gameObject.name == "DownWall")
        {
            transform.position = topWall.transform.position + new Vector3(transform.position.x, -offset, transform.position.z);
           // Debug.Log("DownWall " + transform.position);
        }

        if (other.gameObject.name == "bomb")
        {
            Debug.Log("Bomb!");
        }

       // Debug.Log(this.name + " Trigger 2D with " + other.name + " tag=" + other.tag);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Collider2D other = collision.collider;
        //Debug.Log(this.name + " Collision 2D with " + other.name + " tag=" + other.tag);
    }

    private void OnTriggerEnter(Collider other) {
        //if the player collides with the rightWall 
       // Debug.Log(this.name + " Trigger with name=" + other.name+" tag="+other.tag);
    }

    private void OnCollisionEnter(Collision collision) {
        Collider other = collision.collider;
        //Debug.Log(this.name + " Collision with " + other.name + " tag=" + other.tag);
    }
}
