using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    public GameObject myPlayer;
    public GameObject weapon;
    public Animator Animator;
    public Player player;

    public Transform circleOrigin;
    public float radius;
    public LayerMask whatIsEnemies;

    public int SwordDamage;

    public Collider2D[] enemiesToDamage;

    private void Start()
    {
        SwordDamage = player.pDamage;       
    }

    public void Attack()
    {
        Animator.SetTrigger("Attack");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Vector3 position = circleOrigin == null ? Vector3.zero : circleOrigin.position;
        Gizmos.DrawWireSphere(position, radius);
    }

    public void TurnONColliders()
    {
       
        weapon.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void TurnOFFCollider()
    {
        weapon.GetComponent<BoxCollider2D>().enabled = false;

    }

}
