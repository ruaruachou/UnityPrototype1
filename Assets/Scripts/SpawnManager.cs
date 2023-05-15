using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
   
{
    public GameObject[] spawnAnimals;
    public float spawnPosX = 20;
    public float spawnPoxZ = 20;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPoxZ);
            int animalIndex = Random.Range(0, spawnAnimals.Length);
            Instantiate(spawnAnimals[animalIndex], spawnPos, spawnAnimals[animalIndex].transform.rotation);
        }
    }
}
