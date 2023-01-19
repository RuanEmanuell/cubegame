using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update

    

    void OnCollisionEnter(Collision other) {
        Debug.Log(other.collider.name);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
