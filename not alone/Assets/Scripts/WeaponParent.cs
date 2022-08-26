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

    public int SwordDamage;

    public GameObject trail;
    private TrailRenderer trailRenderer;

    private void Start()
    {
        trailRenderer = trail.GetComponent<TrailRenderer>();
        trailRenderer.enabled = false;
        SwordDamage = player.pDamage;
    }

    public void Attack()
    {
        Animator.SetTrigger("Attack");    
    }

    public void TrailStart()
    {
        trailRenderer.enabled = true;
    }

    public void TrailEnd()
    {
        trailRenderer.enabled = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Vector3 position = circleOrigin == null ? Vector3.zero : circleOrigin.position;
        Gizmos.DrawWireSphere(position, radius);
    }

    public void DetectColliders()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(circleOrigin.position, radius))
        {
            Debug.Log(collider.name);
            Health health = collider.gameObject.GetComponent<Health>();
            if (collider.CompareTag("Enemy"))
            {
                health.GetHit(SwordDamage, transform.parent.parent.gameObject);                
            }else return;
        }
    }
}
