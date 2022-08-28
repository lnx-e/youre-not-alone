using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health health;
    [SerializeField]
    private int eHealth;

    private Rigidbody2D rb;
    private AIDestinationSetter AIDestinationSetter;

    public bool needsRotation = false;

    public float attackDamage = 0.5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AIDestinationSetter = GetComponent<AIDestinationSetter>();
        health.InitializeHealth(eHealth);
    }

    private void Update()
    {
        if (needsRotation)
        {
            Vector3 direction = AIDestinationSetter.target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90;
            rb.rotation = angle;
        }
        
    }
}