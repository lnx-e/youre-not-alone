using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthBar;

    [SerializeField]
    private float currentHealth, maxHealth;


    [SerializeField]
    private bool isDead = false;

    public void InitializeHealth(float healthValue)
    {
        currentHealth = healthValue;
        maxHealth = healthValue;
        healthBar.SetMaxHealth(maxHealth);
        isDead = false;
    }

    public void GetHit(float amount, GameObject sender)
    {
        if (isDead)
            return;
        if (sender.layer == gameObject.layer)
            return;
        Debug.Log("taken damage");
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);

        if (currentHealth > 0)
        {

        }
        else
        {
            isDead = true;
            Destroy(gameObject);
        }
    }
}
