using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Player GameObject to follow.
    public GameObject player;

    // Camera offset from Player's position.
    public Vector3 offset = new Vector3(0, 6, -11);

    // LateUpdate is called once per frame after Update.
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position.
        transform.position = player.transform.position + offset;
    }
}
