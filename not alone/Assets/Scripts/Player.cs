using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 movementVector;
    private WeaponParent weaponParent;
    public PlayerHealth health;
    public GameObject weapon;
    public GameObject ob;

    [SerializeField] float speed = 5;

    public int pHealth;
    public int swordDamage = 2;

    public float autoAttackCooldown;
    public float autoAttackCurTime;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
        weaponParent = weapon.GetComponent<WeaponParent>();
        
    }

    private void Start()
    {
        health.InitializeHealth(pHealth);
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        movementVector *= speed;

        rb.velocity = movementVector;

        if (autoAttackCurTime < autoAttackCooldown)
        {
            autoAttackCurTime += Time.deltaTime;
        }
        else
        {
            weaponParent.Attack();
            autoAttackCurTime = 0;
        }

        if (Input.GetMouseButtonDown(0))
        {
            health.GetHit(1, ob);
        }
    }

    
}
