using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Générer une balle aléatoire à une position x aléatoire en haut de l'aire de jeu
    void SpawnRandomBall ()
    {
        // Générer un index aléatoire et une position d'apparition aléatoire
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int indexBalls = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[indexBalls], spawnPos, ballPrefabs[indexBalls].transform.rotation);

        int spawnInterval = Random.Range(3, 6);
        Invoke("SpawnRandomBall", spawnInterval);
    }
}
