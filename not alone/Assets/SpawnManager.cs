using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Waves
{
    public string waveName;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
    public int waveDuration;
}

public class SpawnManager : MonoBehaviour
{
    [SerializeField] Waves[] waves;
    public Transform[] spawnPoints;
    public float delayBetweenWaves;

    private Waves currentWave;
    private int currentWaveNumber = -1;
    private float nextSpawnTime;
    private bool canSpawn = true;
    [SerializeField]
    private int currentTime;

    private Timer timer;

    private void Start()
    {
        timer = GameObject.Find("GameManager").GetComponent<Timer>();
        
    }

    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        Debug.Log(waves[currentWaveNumber].waveName);
        currentTime = (int)Mathf.Round(timer.timeLeft);
        SpawnWave();
        
        if (currentWave.waveDuration == currentTime && !canSpawn && currentWaveNumber + 1 != waves.Length)
        {            
            currentWaveNumber++;
            StartCoroutine(WaitBetweenWaves());
            
        }
    }

    IEnumerator WaitBetweenWaves()
    {
        Debug.Log("waiting");
        yield return new WaitForSecondsRealtime(delayBetweenWaves);
        canSpawn = true;
        Debug.Log("start spawn");
    }

    void SpawnWave()
    {
        if(canSpawn && nextSpawnTime < Time.time)
        {
            StopCoroutine(WaitBetweenWaves());
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomSpawnLocation = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomEnemy, randomSpawnLocation.position, Quaternion.identity);
            nextSpawnTime = Time.time + currentWave.spawnInterval;

            if(currentWave.waveDuration == currentTime)
            {
                canSpawn = false;
                Debug.Log("stop spawn");

            }

        }
        
    }
}
