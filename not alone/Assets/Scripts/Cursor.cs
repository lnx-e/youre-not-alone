using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject player;
    public GameObject playerSpawn;
    public GameObject enemySpawn;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
        Instantiate(player, playerSpawn.transform);
        Instantiate(enemy, enemySpawn.transform);
        Instantiate(enemy, enemySpawn.transform);
    }

}
