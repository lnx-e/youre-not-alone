using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInSight : MonoBehaviour
{
    public bool enemyInView = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemyInView = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemyInView = false;
        }
    }


}
