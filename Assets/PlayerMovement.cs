using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            Debug.Log("cu");
            rb.AddForce(0, 0, 2000*Time.deltaTime);
        }
        if(Input.GetKey("s")){
            Debug.Log("cu");
            rb.AddForce(0, 0, -2000*Time.deltaTime);
        }
        if(Input.GetKey("d")){
            Debug.Log("cu");
            rb.AddForce(2000*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")){
            Debug.Log("cu");
            rb.AddForce(-2000*Time.deltaTime, 0, 0);
        }
    }
}
