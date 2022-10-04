using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{

    public WeaponParent weaponParent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();
        health.GetHit(weaponParent.SwordDamage, transform.parent.parent.parent.gameObject);
        
    }
}
