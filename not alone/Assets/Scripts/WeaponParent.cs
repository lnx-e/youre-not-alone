using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    public GameObject myPlayer;
    public Animator Animator;
    public Player player;

    public Transform circleOrigin;
    public float radius;
    public LayerMask whatIsEnemies;

    public int SwordDamage;


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

    public void DetectColliders()
    {
        //foreach(Collider2D collider in Physics2D.OverlapCircleAll(circleOrigin.position, radius, whatIsEnemies))
        //{
        //    Health health = collider.gameObject.GetComponent<Health>();
        //    if (collider.CompareTag("Enemy"))
        //    {
        //        Debug.Log(collider.name);
        //        health.GetHit(SwordDamage, transform.parent.parent.gameObject);                
        //    }else return;
        //}
        
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(circleOrigin.position, radius, whatIsEnemies);
        for(int i = 0; i < enemiesToDamage.Length; i++)
        {
            enemiesToDamage[i].GetComponent<Health>().GetHit(SwordDamage, transform.parent.parent.gameObject);
        }
    }
}
