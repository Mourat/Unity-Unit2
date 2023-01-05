using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;
    private const float TimeStep = 1.0f / 60.0f;
    private Vector3 _forward;

    private void Reset()
    {
        speed = 10f;
    }

    private void Awake()
    {
        _forward = Vector3.forward;
    }

    private void Update()
    {
        transform.Translate(_forward * (TimeStep * speed));
    }
}
