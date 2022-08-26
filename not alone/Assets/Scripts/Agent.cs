using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public AgentMovement agentMovement;
    public Health health;

    private Vector2 movementInput;

    [SerializeField]
    private int eHealth;

    public float attackDamage = 0.5f;

    public Vector2 MovementInput { get => movementInput; set => movementInput = value; }

    private void Start()
    {
        health.InitializeHealth(eHealth);
    }

    private void Update()
    {
        agentMovement.MovementInput = MovementInput;     
    }

}
