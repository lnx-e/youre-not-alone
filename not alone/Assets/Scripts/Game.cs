using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public GameObject player;
    public GameObject playerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, playerSpawn.transform);
    }

}
