using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject player;
    public GameObject playerSpawn;

    public GameObject enemy;
    public GameObject enemySpawn;

    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(player, playerSpawn.transform);
        Instantiate(enemy, enemySpawn.transform);
    }

}
