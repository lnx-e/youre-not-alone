using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 movementVector;
    private WeaponParent weaponParent;
    public GameObject weapon;

    [SerializeField] float speed = 5;



    public float autoAttackCooldown;
    public float autoAttackCurTime;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
        weaponParent = weapon.GetComponent<WeaponParent>();
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
    }

    private void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ -= 90);

    }
}
