using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    /* Use a fixed time step: If your game is running at a fixed frame rate,
    you can use a fixed time step to update the object's position,
    rather than using Time.deltaTime. This can help improve the consistency
    of the object's movement, as well as the performance of your code. */
    private const float TimeStep = 1.0f / 60.0f;
    private Vector3 _right;
    [SerializeField] private float xRange;

    private void Reset()
    {
        speed = 10.0f;
        xRange = 15f;
    }

    private void Awake()
    {
        _right = transform.right;
    }

    private void Update()
    {
        var pos = transform.position;
        var horizontalInput = Input.GetAxis("Horizontal");
        
        /* Mathf.Clamp function to constrain the x coordinate of the object's position
        to the range [-24, 24]. This is more concise than using an if statement.*/ 
        pos.x = Mathf.Clamp(pos.x, -xRange, xRange);
        
        transform.position = pos;
        
        transform.Translate(_right * horizontalInput * TimeStep * speed);
    }
}
