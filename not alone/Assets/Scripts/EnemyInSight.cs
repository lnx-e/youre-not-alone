using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class EnemyInSight : MonoBehaviour
{
    public bool enemyInView = false;

    public List<GameObject> enemiesInView = new List<GameObject>();

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemyInView = true;
            if (!enemiesInView.Contains(collision.gameObject))
            {
                enemiesInView.Add(collision.gameObject);
            }
        }        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemyInView = false;
            enemiesInView.Remove(collision.gameObject);
        }
    }


}
