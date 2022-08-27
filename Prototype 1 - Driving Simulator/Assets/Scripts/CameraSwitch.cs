using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// OVERVIEW:
// This script alternates cameras with a key press.
// When the key is pressed, the current camera is deactivated and the other one is activated.

// DEPENDENCIES:
// A key input in the InputManager named "SwitchCamera".

public class CameraSwitch : MonoBehaviour 
{
    // Slots for the two cameras.
    public GameObject camera1;
    public GameObject camera2;

    void Update()
    {
        // Check for user input.
        if (Input.GetButtonDown("CameraSwitch"))
        {
            // Switch to Camera 2
            if (camera1.activeSelf == true)
            {
                camera1.SetActive(false);
                camera2.SetActive(true);
            }
            // Switch to Camera 1
            else
            {
                camera1.SetActive(true);
                camera2.SetActive(false);
            }
        }
    }
}