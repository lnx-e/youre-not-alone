using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    ScoreManager scoreManagerScript;
    GameObject scoreManager;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
        scoreManagerScript = scoreManager.GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coins"))
        {
            scoreManagerScript.newScore = other.GetComponent<coin>().CoinValue;
            Destroy(other.gameObject);
        }
    }
}
