using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f; // 10 units to the left and 10 units to the right

    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        // Shoot proyectile.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }


        horizontalInput = Input.GetAxis("Horizontal"); // GetAxis returns a value between -1 and 1.

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // Move the player right or left based on horizontalInput.
    }
}
