using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
   
{
    public GameObject[] spawnAnimals;
    public float spawnPosX = 20;
    public float spawnPoxZ = 20;
    public float spawnDelay = 2;
    public float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);   
    }
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPoxZ);
        int animalIndex = Random.Range(0, spawnAnimals.Length);
        Instantiate(spawnAnimals[animalIndex], spawnPos, spawnAnimals[animalIndex].transform.rotation);
    }
}
