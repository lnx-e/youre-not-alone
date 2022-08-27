using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public AgentMovement agentMovement;

    private WeaponParent weaponParent;
    private PlayerHealth health;
    public GameObject weapon;

    private Vector2 movementInput;

    public int pHealth;
    public int pDamage = 2;

    public float autoAttackCooldown;
    public float autoAttackCurTime;


    public Vector2 MovementInput { get => movementInput; set => movementInput = value; }

    // Start is called before the first frame update
    void Awake()
    {
        weaponParent = weapon.GetComponent<WeaponParent>();
        health = GetComponent<PlayerHealth>();
    }

    private void Start()
    {
        health.InitializeHealth(pHealth);
    }

    // Update is called once per frame
    void Update()
    {  
        agentMovement.MovementInput = MovementInput;

        //auto attack
        if (autoAttackCurTime < autoAttackCooldown)
        {
            autoAttackCurTime += Time.deltaTime;
        }
        else
        {
            weaponParent.Attack();
            autoAttackCurTime = 0;
        }
    }
   
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            float attackDamage = col.gameObject.GetComponent<Enemy>().attackDamage;
            health.GetHit(attackDamage, col.transform.gameObject);
        }else return;
    }

}
