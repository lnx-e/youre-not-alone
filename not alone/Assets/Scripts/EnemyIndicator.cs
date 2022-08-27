using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
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

        if (enemyInSight.enemyInView == false)
        {
            if(indicator.activeSelf == false)
            {
                indicator.SetActive(true);
            }

            Vector2 direction = target.transform.position - transform.position;
            RaycastHit2D ray = Physics2D.Raycast(transform.position, direction, Mathf.Infinity, SpotLayer);
            Color rayColor;
            if (ray.collider != null)
            {
                rayColor = Color.green;
                indicator.transform.position = ray.point;
            }
            else
            {
                rayColor = Color.red;
            }
            Debug.DrawRay(transform.position, direction, rayColor);
            Debug.Log(ray.point);                      

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

