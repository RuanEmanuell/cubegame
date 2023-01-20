using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update

    void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Obstacle"){
            GetComponent<PlayerMovement>().enabled=false;
            FindObjectOfType<GameController>().GameOver();
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
