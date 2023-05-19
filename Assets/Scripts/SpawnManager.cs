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
    private string[] spawnDirection = { "up", "left", "right" };//ȷ���������������

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);   
    }
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        string direction = spawnDirection[Random.Range(0, spawnDirection.Length)];//���������������һ��
        switch (direction)
        {
            case "up":
                Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPoxZ);
                int animalIndex = Random.Range(0, spawnAnimals.Length);
                Instantiate(spawnAnimals[animalIndex], spawnPos, spawnAnimals[animalIndex].transform.rotation);
                break;

            case "left":
                Vector3 spawnPos1 = new Vector3(-spawnPosX, 0, Random.Range(-spawnPoxZ,spawnPoxZ));
                int animalIndex1 = Random.Range(0, spawnAnimals.Length);
                Instantiate(spawnAnimals[animalIndex1], spawnPos1, Quaternion.LookRotation(Vector3.right));
                break;

            default://��
                Vector3 spawnPos2 = new Vector3(spawnPosX,0,Random.Range(-spawnPoxZ,spawnPoxZ));
                int animalIndex2 = Random.Range(0, spawnAnimals.Length);
                Instantiate(spawnAnimals[animalIndex2], spawnPos2, Quaternion.LookRotation(Vector3.left));
                break;
        }

    }
}
