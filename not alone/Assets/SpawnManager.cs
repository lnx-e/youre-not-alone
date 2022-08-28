using UnityEngine;

using UnityEngine.UI;

[System.Serializable]

public class Wave

{

    public string waveName;

    public int noOfEnemies;

    public GameObject[] typeOfEnemies;

    public float spawnInterval;

}

public class SpawnManager : MonoBehaviour

{

    public Wave[] waves;

    public Transform[] spawnPoints;

    

    private Wave currentWave;

    private int currentWaveNumber;

    private float nextSpawnTime;

    private bool canSpawn = true;




    private void Update()

    {

        currentWave = waves[currentWaveNumber];

        SpawnWave();

        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (totalEnemies.Length == 0)

        {

            if (currentWaveNumber + 1 != waves.Length)

            {

                currentWaveNumber++;

                canSpawn = true;


            }
            else
            {
            }

        }



    }

    

    void SpawnWave()

    {

        if (canSpawn && nextSpawnTime < Time.time)

        {

            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];

            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);

            currentWave.noOfEnemies--;

            nextSpawnTime = Time.time + currentWave.spawnInterval;

            if (currentWave.noOfEnemies == 0)

            {
                canSpawn = false;
            }

        }



    }

}
