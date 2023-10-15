using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float spawnRangeX = 15.0f;
    private float spawnPositionZ = 35f;
    private float spawnDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
        }
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length); //Random avec int, le max est exclu
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ); //Random avec float, le maximum est inclus

        Instantiate(animalsPrefabs[animalIndex], spawnPosition, animalsPrefabs[animalIndex].transform.rotation);
    }
}
