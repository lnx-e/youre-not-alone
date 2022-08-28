using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIndicator : MonoBehaviour
{
    public GameObject indicator;
    private GameObject target;
    private GameObject visionCone;

    public LayerMask SpotLayer;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        visionCone = GameObject.FindGameObjectWithTag("VisionCone");
    }

    private void FixedUpdate()
    {
        EnemyInSight enemyInSight = visionCone.GetComponent<EnemyInSight>();

        if (!enemyInSight.enemiesInView.Contains(gameObject))
        {
            if(indicator.activeSelf == false)
            {
                indicator.SetActive(true);
            }

            Vector2 direction = target.transform.position - transform.position;
            RaycastHit2D ray = Physics2D.Raycast(transform.position, direction, Mathf.Infinity, SpotLayer);
            if (ray.collider != null)
            {              
                indicator.transform.position = ray.point;
            }
                         

        }
        else
        {
            if (indicator.activeSelf == true)
            {
                indicator.SetActive(false);
            }
        }
    }

    
}

