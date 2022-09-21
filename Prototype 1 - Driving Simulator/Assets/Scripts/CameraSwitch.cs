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
    public string switchKey = "SwitchCamera";

    void Update()
    {
        // Check for user input.
        if (Input.GetButtonDown(switchKey))
        {
            // Switch cameras.
            camera1.SetActive(!camera1.activeSelf);
            camera2.SetActive(!camera2.activeSelf);
        }
    }
}