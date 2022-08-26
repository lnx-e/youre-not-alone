using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{

    public int escape = 0;
    public GameObject player;
    public GameObject playerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
        Instantiate(player, playerSpawn.transform);
    }

}
