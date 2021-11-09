using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollideWithPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {

        // when we catch a bomb falling, we want to eliminate all the enemies -> the spaceships that are falling
        if (other.tag == "Player")
        {
            Debug.Log("Bomb");
            // we are finding all the gameobjects with the tag enemy 
            var clones = GameObject.FindGameObjectsWithTag("Enemy");
            // each gameobject we found -> we destroy it
             foreach (var clone in clones)
            {
                Destroy(clone);
            }
             //destryoing the bomb itself that we just hit
            Destroy(this.gameObject);
           
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
