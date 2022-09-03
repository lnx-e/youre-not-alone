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
        GameObject.FindGameObjectWithTag("Player").GetComponent<AgentMovement>().enabled = false;
        StartCoroutine("");


    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, playerSpawn.transform);
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
