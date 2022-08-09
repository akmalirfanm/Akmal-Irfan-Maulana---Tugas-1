using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]


public class Wave {
    public string waveName;
    public int noOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}


public class Spawn : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] wavePoints;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    private bool canSpawn = true;


    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Zombies");
        if (totalEnemies.Length == 0 && !canSpawn)
        {
            currentWaveNumber++;
            canSpawn = true;
        }
    }

    void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomPoint = wavePoints[Random.Range(0, wavePoints.Length)];
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