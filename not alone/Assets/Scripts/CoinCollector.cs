using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollector : MonoBehaviour
{
    //public AudioSource audioSource;
    ScoreManager scoreManagerScript;
    GameObject scoreManager;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        scoreManagerScript = scoreManager.GetComponent<ScoreManager>();
        //audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coins"))
        {
            scoreManagerScript.newScore = col.GetComponent<Coin>().CoinValue;
            Destroy(col.gameObject);
        }
    }
}
