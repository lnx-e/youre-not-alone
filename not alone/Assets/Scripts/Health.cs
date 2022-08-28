using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float currentHealth, maxHealth;

    [SerializeField]
    private bool isDead = false;

    public GameObject coin;
    public GameObject enemy;

    [SerializeField]
    private SimpleFlash flashEffect;

    public Animator animator;



    public void InitializeHealth(int healthValue)
    {
        currentHealth = healthValue;
        maxHealth = healthValue;
        isDead = false;
    }

    public void GetHit(float amount, GameObject sender)
    {
        if (isDead)
            return;
        if (sender.layer == gameObject.layer)
            return;

        currentHealth -= amount;

        flashEffect.Flash();

        if (currentHealth > 0)
        {

        }
        else
        {
            isDead = true;
            animator.SetTrigger("Death");
            Destroy(gameObject, 0.5f);
            Instantiate(coin, transform.position, Quaternion.identity);            
        }
    }

    
   
}
