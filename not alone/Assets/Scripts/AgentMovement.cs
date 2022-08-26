using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    private Vector2 oldMovementInput;
    public Vector2 MovementInput { get; set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        oldMovementInput = MovementInput;
        oldMovementInput *= speed;
        rb.velocity = oldMovementInput;
    }
}
