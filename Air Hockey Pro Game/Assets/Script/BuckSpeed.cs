using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuckSpeed : MonoBehaviour
{
    public int maxSpeed = 10;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }
}
