using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Private Variables
    private float speed = 10.0f;
    //private float turnSpeed = 65.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward or back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move the car left or right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        //transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
