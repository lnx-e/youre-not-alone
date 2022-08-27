using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health health;
    [SerializeField]
    private int eHealth;

    public float attackDamage = 0.5f;

    private void Start()
    {
        health.InitializeHealth(eHealth);
    }
}