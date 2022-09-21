using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    public float speed = 15.0f;
    public float turnSpeed = 45.0f;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // Check user input.
        horizontalInput = Input.GetAxis(horizontalAxis);
        forwardInput = Input.GetAxis(verticalAxis);

        // Move the vehicle forward according to user input.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Turn the vehicle according to user input.
        transform.Rotate(Vector2.up, Time.deltaTime * turnSpeed * horizontalInput); // Turn
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); // Slide
    }
}
