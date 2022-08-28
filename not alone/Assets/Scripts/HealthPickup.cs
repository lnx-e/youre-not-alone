using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        GameObject whatHit = col.gameObject;
        if (whatHit.CompareTag("Player"))
        {
            whatHit.GetComponent<Player>().pHealth = 10;
            Destroy(gameObject);
        }
    }
}
