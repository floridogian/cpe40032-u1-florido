using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 22.0f; // the speed of the vehicle
    private float turnSpeed = 50.0f; // the turn speed of the vehicle
    private float horizontalInput; // turn/rotate the vehicle to the left or right using the left and right arrow keys or the letter A and D.
    private float forwardInput; // move the vehicle either forward or backward using the up and down arrow keys or letter W and S.

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // This is the code for the player input to control the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
