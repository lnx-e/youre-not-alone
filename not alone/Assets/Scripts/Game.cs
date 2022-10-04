using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject player;
    public GameObject playerSpawn;

    public GameObject enemy;

    private void Awake()
    {
        Instantiate(player, GameObject.Find("playerSpawner").transform);
    }

    // Start is called before the first frame update
    private void Start()
    {
        Instantiate(enemy, GameObject.Find("enemySpawner").transform);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}