using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float timeToSpawn = 5f;
    public float resetTimer;
    public int maxNumOfEnemy = 3;
    public static int enemyNum;

    public GameObject[] spawnerLocations;    
    int spawnNum = 3;
    int enemySpawnNum = 1;

    // Start is called before the first frame update
    void Awake()
    {
        enemyNum = maxNumOfEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        spawnNum = Random.Range(0, spawnerLocations.Length);
        enemySpawnNum = Random.Range(0, enemyPrefab.Length);

        timeToSpawn -= 1f; // Start CountDown
        if (timeToSpawn <= 0 && maxNumOfEnemy != 0)
        {
            Instantiate(enemyPrefab[enemySpawnNum], spawnerLocations[spawnNum].transform.position, Quaternion.identity);
            maxNumOfEnemy--;
            timeToSpawn = resetTimer;   
        }
    }
}
