using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 direction = Vector3.forward;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * direction * Time.deltaTime);
    }
}
