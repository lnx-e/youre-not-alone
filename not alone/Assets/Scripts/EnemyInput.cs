using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyInput : MonoBehaviour
{
    public UnityEvent<Vector2> OnMovementInput;

    [SerializeField]
    private GameObject player;
    private Transform playerTransform;

    [SerializeField]
    private float chaseDistanceThreshold = 3;

    
    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;

        if (player == null)
            return;

        float distance = Vector2.Distance(playerTransform.position, transform.position);
        if(distance < chaseDistanceThreshold)
        {
            //chasng the player
            Vector2 direction = playerTransform.position - transform.position;
            OnMovementInput?.Invoke(direction.normalized);
        }
    }

}
